using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Header : MonoBehaviour
{
    public GameObject Weapons_Container;
    public GameObject Armor_Container;
    public GameObject Skills_Container;
    public GameObject Map_Container;
    public GameObject Lore_Container;

    private bool weapons_active = true;
    private bool armor_active = false;
    private bool skills_active = false;
    private bool map_active = false;
    private bool lore_active = false;

    void Update()
    {
        if (weapons_active && !armor_active && !skills_active && !map_active && !lore_active)
        {
            Weapons_Container.gameObject.SetActive(true);
            Armor_Container.gameObject.SetActive(false);
            Skills_Container.gameObject.SetActive(false);
            Map_Container.gameObject.SetActive(false);
            Lore_Container.gameObject.SetActive(false);
        }

        if (!weapons_active && armor_active && !skills_active && !map_active && !lore_active)
        {
            Weapons_Container.gameObject.SetActive(false);
            Armor_Container.gameObject.SetActive(true);
            Skills_Container.gameObject.SetActive(false);
            Map_Container.gameObject.SetActive(false);
            Lore_Container.gameObject.SetActive(false);
        }

        if (!weapons_active && !armor_active && skills_active && !map_active && !lore_active)
        {
            Weapons_Container.gameObject.SetActive(false);
            Armor_Container.gameObject.SetActive(false);
            Skills_Container.gameObject.SetActive(true);
            Map_Container.gameObject.SetActive(false);
            Lore_Container.gameObject.SetActive(false);
        }

        if (!weapons_active && !armor_active && !skills_active && map_active && !lore_active)
        {
            Weapons_Container.gameObject.SetActive(false);
            Armor_Container.gameObject.SetActive(false);
            Skills_Container.gameObject.SetActive(false);
            Map_Container.gameObject.SetActive(true);
            Lore_Container.gameObject.SetActive(false);
        }

        if (!weapons_active && !armor_active && !skills_active && !map_active && lore_active)
        {
            Weapons_Container.gameObject.SetActive(false);
            Armor_Container.gameObject.SetActive(false);
            Skills_Container.gameObject.SetActive(false);
            Map_Container.gameObject.SetActive(false);
            Lore_Container.gameObject.SetActive(true);
        }
    }

    public void WeaponsButton_Click()
    {
        weapons_active = true;
        armor_active = false;
        skills_active = false;
        map_active = false;
        lore_active = false;
    }

    public void ArmorButton_Click()
    {
        weapons_active = false;
        armor_active = true;
        skills_active = false;
        map_active = false;
        lore_active = false;
    }

    public void SkillsButton_Click()
    {
        weapons_active = false;
        armor_active = false;
        skills_active = true;
        map_active = false;
        lore_active = false;
    }

    public void MapButton_Click()
    {
        weapons_active = false;
        armor_active = false;
        skills_active = false;
        map_active = true;
        lore_active = false;
    }

    public void LoreButton_Click()
    {
        weapons_active = false;
        armor_active = false;
        skills_active = false;
        map_active = false;
        lore_active = true;
    }
}
