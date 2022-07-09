using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_spawn_manager : MonoBehaviour
{
    int i;
    public Sprite wood;
    public Sprite tape;
    public Sprite tetkai;
    public Sprite iron;
    public Sprite ilectronic;
    public Sprite cpu;
    public SpriteRenderer[] house;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int u = 0; u < 43; u++)
        {
            i = Random.Range(1, 100);
            if (i <= 100 && i > 95)
            {
                house[u].sprite = wood;
            }
            else if (i <= 95 && i > 90)
            {
                house[u].sprite = tape;
            }
            else if (i <= 90 && i > 83)
            {
                house[u].sprite = iron;
            }
            else if (i <= 83 && i > 76)
            {
                house[u].sprite = ilectronic;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
