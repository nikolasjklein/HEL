using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_EntryPoint : MonoBehaviour
{
    public Transform PortalExitPoint;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = PortalExitPoint.transform.position;
            other.transform.rotation = PortalExitPoint.transform.rotation;
        }

        Debug.Log (other.transform.position);
        Debug.Log (PortalExitPoint.transform.position);
    }
}
