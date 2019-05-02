using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Player : MonoBehaviour
{
    #region Singleton

    public static GameManager_Player instance;

    public void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;
}
