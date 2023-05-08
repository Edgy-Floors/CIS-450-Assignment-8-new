using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : Equipment
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

    protected override bool IsEquipped()
    {
        return equipped;
    }
}
