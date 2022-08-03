using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item : Panel
{

    // 아이템 종류 정하기 ( 0 - 9)
    //  주인공의 인벤토리 [ 0, 0, 1, 5, 6]
    //  
    public SpriteRenderer[] item = new SpriteRenderer[200]; // 아이템의 사진
    public string[] item_name = new string[200]; // 각 아이템의 이름     
    public int[] item_quantity = new int[200]; // item_quantity[7] = 5
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Itemrender()
    {
        
    }
    
}
