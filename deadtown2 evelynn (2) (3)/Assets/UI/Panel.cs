using UnityEngine;

public class Panel : MonoBehaviour
{
    public Item itemRender;
    public int Invenstage = 0;
    public int a = 0;
    public GameObject Item_ingrediants;
    public GameObject PreviousButton;
    public GameObject itemPreviousButton;
    public GameObject Items_inven;
    public GameObject Inven;

    // Start is called before the first frame update
    void Start()
    {

        Inven.SetActive(false);
        PreviousButton.SetActive(false);
        itemPreviousButton.SetActive(false);
        Items_inven.SetActive(false);
        Item_ingrediants.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonDown()
    {
        a++;
        if (a % 2 == 0)
        {
            Invenstage = 0;
        }
        if (a % 2 != 0)
        {
            Invenstage = 1;
        }
    }
    public void ItemDown()
    {
        Invenstage = 2;
    }
    public void ingrediantsdown()
    {
        Invenstage = 7;
    }


    public void itemPreviousButton_Down()
    {
        Invenstage = 1;
    }

    public void PreviousButton_down()
    {
        Invenstage = 2;
    }

    public void invenpublic()
    {
        if(Invenstage == 0)
        {
            Inven.SetActive(false);
            PreviousButton.SetActive(false);
            itemPreviousButton.SetActive(false);
            Items_inven.SetActive(false);
            Item_ingrediants.SetActive(false);
        }
        if (Invenstage == 1)
            Inven.SetActive(true);
        else
            Inven.SetActive(false);

        if(Invenstage == 2)
            Items_inven.SetActive(true);
        else
            Items_inven.SetActive(false);

        if (Invenstage == 7)
        {
            Item_ingrediants.SetActive(true);
            itemRender.Itemrender();
        }
        else
            Item_ingrediants.SetActive(false);

        if (((Invenstage > 7 || Invenstage < 5) && Invenstage != 0) && Invenstage != 1)
            itemPreviousButton.SetActive(true);
        else
            itemPreviousButton.SetActive(false);

        if (Invenstage < 8 && Invenstage > 4)
            PreviousButton.SetActive(true);
        else
            PreviousButton.SetActive(false);
    }
}
