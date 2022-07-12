using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public bool pause=false;
    public int a=0;
    public GameObject panel;
    public int Inven_stage = 0;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void GetButtonDown()
    {
       a = a+1;
        
        if (a % 2 == 0||Inven_stage!=0)
        {
            panel.SetActive(false);
        }
        else if (a % 2 != 0 && Inven_stage==0)
        {
            panel.SetActive(true);
            pause = true;
        }
    }
}
