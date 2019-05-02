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
    public Slider playerHealthBar;

    public int pA;
    public Text playerArmour;
    public Slider playerArmourBar;

    public void Start()
    {
        //set player health to 100 at start
        pL = 100;
        pA = 0;
    }

    public void Update()
    {
        //display the player health in UI
        playerHealth.text = pL.ToString();
        playerArmour.text = pA.ToString();

        playerHealthBar.value = pL;
        playerArmourBar.value = pA;

        if (pL < 0)
            pL = 0;

        if (pL > 100)
            pL = 100;

        if (pA < 0)
            pA = 0;

        if (pA > 100)
            pA = 100;
    }
}
