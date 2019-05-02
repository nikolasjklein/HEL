using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Stats : MonoBehaviour
{
    [Header("Player Life")]
    [Tooltip("The Maximum Health Points the Player can have")]
    public int pL;
    [Header("Player Health Text")]
    [Tooltip("The text which represents the Player Health on the GUI")]
    public Text playerHealth;

    public void Start()
    {
        //set player health to 100 at start
        pL = 100;
    }

    public void Update()
    {
        //display the player health in UI
                    //playerHealth.text = pL.ToString();
        //Debug.Log(playerLife);
    }
}
