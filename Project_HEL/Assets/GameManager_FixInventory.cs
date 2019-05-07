using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_FixInventory : MonoBehaviour
{
    public GameManager_ToggleInventory toggleInventory;
    public Canvas Inventory;
    public float delay = .1f;

    public void Awake()
    {
        toggleInventory.isToggled = true;
        StartCoroutine(ToggleInventory(Inventory.gameObject, delay));
    }

    private IEnumerator ToggleInventory(GameObject inventory, float delay)
    {
        yield return new WaitForSeconds(delay);

        toggleInventory.isToggled = false;
    }
}
