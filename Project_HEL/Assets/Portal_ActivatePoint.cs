using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_ActivatePoint : MonoBehaviour
{
    public GameObject PortalEntryPoint;

    public void Start()
    {
        PortalEntryPoint.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PortalEntryPoint.gameObject.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PortalEntryPoint.gameObject.SetActive(false);
        }
    }
}
