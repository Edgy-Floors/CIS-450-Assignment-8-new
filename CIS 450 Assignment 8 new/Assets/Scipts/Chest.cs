using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Equipment
{
    private bool equipped = false;

    protected override void ApplyEquipment()
    {
        objToEquip.SetActive(true);
        equipped = true;
    }

    protected override void RemoveEquipment()
    {
        objToEquip.SetActive(false);
        equipped = false;
    }

    protected override void OnEquip()
    {
        if(IsEquipped())
        {
            tmp.text = "You have put on a chestplate.";
        }
    }

    protected override void OnUnequip()
    {
        if(!IsEquipped())
        {
            tmp.text = "You have removed the chestplate.";
        }
    }

    protected override bool IsEquipped()
    {
        return equipped;
    }
}
