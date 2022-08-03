using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Previous_button : Panel
{
    // Start is called before the first frame update
    void Start()
    {
        PreviousButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnclickPrevious()
    {
        
        if (a%2==0)
        {
            PreviousButton.SetActive(false);
        }
        if(a%2!=0)
        {
            PreviousButton.SetActive(true);
        }
    }
   
}
