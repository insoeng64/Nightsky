using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item : Panel
{

    // ������ ���� ���ϱ� ( 0 - 9)
    //  ���ΰ��� �κ��丮 [ 0, 0, 1, 5, 6]
    //  
    public SpriteRenderer[] item = new SpriteRenderer[200]; // �������� ����
    public string[] item_name = new string[200]; // �� �������� �̸�     
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
