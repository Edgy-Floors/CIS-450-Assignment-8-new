using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Equipment e;
    public Equipment c;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            e.Equip();
        }    
        if(Input.GetKeyDown(KeyCode.R))
        {
            e.Unequip();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            c.Equip();
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            c.Unequip();
        }
    }
}
