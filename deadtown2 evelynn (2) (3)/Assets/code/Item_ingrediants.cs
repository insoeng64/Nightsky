using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_ingrediants : Item
{
    public RectTransform cell;
    public RectTransform cells;
    Vector2 position=new Vector2(0,400);
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        cell = GetComponent<RectTransform>();
        cells = GetComponent<RectTransform>();
        for(int i=0;i<9;i++)
        {
            position.y = position.y-(200*i);
            Instantiate(prefab, position);
             
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
