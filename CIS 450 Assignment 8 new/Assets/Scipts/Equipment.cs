using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Equipment : MonoBehaviour
{
    public GameObject objToEquip;
    public TextMeshProUGUI tmp;

    public void Equip()
    {
        if (!IsEquipped())
        {
            ApplyEquipment();
            OnEquip();
        }
    }

    public void Unequip()
    {
        if (IsEquipped())
        {
            RemoveEquipment();
            OnUnequip();
        }
    }

    protected abstract void ApplyEquipment();
    protected abstract void RemoveEquipment();

    protected abstract bool IsEquipped();

    protected virtual void OnEquip()
    {
        if(IsEquipped())
        {
            tmp.text = "You have equipped an item.";
        }
    }

    protected virtual void OnUnequip()
    {
        if(!IsEquipped())
        {
            tmp.text = "You have unequipped an item.";
        }
    }
}
