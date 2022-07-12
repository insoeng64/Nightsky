using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigid;
    Rigidbody2D rig;
    SpriteRenderer SpriteRend;
    Animator ani;
    public static bool isRight = true;
    Vector2 Inputmouseposition;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        SpriteRend = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseposition_gap;
        Vector2 previousmouseposition = Inputmouseposition;
        Inputmouseposition=Input.mousePosition;
        mouseposition_gap = Inputmouseposition - previousmouseposition;
       
        //캐릭터 이동 스크립트
        if (Input.GetKey(KeyCode.W))
        {
            ani.SetBool("walk", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            ani.SetBool("walk", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ani.SetBool("walk", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ani.SetBool("walk", true);
        }
        else
        {
            ani.SetBool("walk", false);
        }

       


        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z+ mouseposition_gap.x*-0.5f);



    }//캐릭터 이동 스크립트
     void FixedUpdate()
    {
        float val = Input.GetAxisRaw("Horizontal");//이동
        transform.Translate(new Vector2(val * 0.1f, 0));

        float bal = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector2(0, bal * 0.1f));

        if (Input.GetKey(KeyCode.G))
        {
            ani.SetBool("attack doki", true);//도끼 사용
        }
        else
        {
            ani.SetBool("attack doki", false);
        }


    }
    }

