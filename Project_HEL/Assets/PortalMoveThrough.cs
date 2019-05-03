using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMoveThrough : MonoBehaviour
{
    public Transform PortalExitPoint;

    public GameObject Player;

    public void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Player_Controller>().enabled = false;
            StartCoroutine("ActivateController");

            if (other.GetComponent<Player_Controller>().enabled == false)
                Debug.Log("YEET");

            other.transform.position = PortalExitPoint.transform.position;
            other.transform.rotation = PortalExitPoint.transform.rotation;
        }

        Debug.Log (other.transform.position);
        Debug.Log (PortalExitPoint.transform.position);
    }

    IEnumerator ActivateController()
    {
        yield return new WaitForSeconds(0.05f);

        Player.GetComponent<Player_Controller>().enabled = true;
        Debug.Log("YEET_2");
    }
}