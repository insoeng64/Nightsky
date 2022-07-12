using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_inven : Panel
{
    public GameObject Items_inven;
    
    // Start is called before the first frame update
    void Start()
    {
        Items_inven.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void GetButtonDown()
    {
        Inven_stage = Inven_stage + 1;

        if (In % 2 == 0)
        {
            panel.SetActive(false);
        }
        else if (a % 2 != 0)
        {
            panel.SetActive(true);
            pause = true;
        }
    }
}
