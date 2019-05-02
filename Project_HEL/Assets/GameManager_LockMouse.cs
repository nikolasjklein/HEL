using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_LockMouse : MonoBehaviour
{
    public void Awake()
    {
        //set mouse cursor to not visible on awake - it was visible before due to a check in the inventory system
        Cursor.visible = false;
    }
}
