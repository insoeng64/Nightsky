using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Playermove : MonoBehaviour
{
    // Start is called before the first frame update
    public Joystick speed;
    public GameObject handle;
    public FloatingJoystick Direction;
    Rigidbody rigid;
    Rigidbody2D rig;
    SpriteRenderer SpriteRend;
    Animator ani;
    public static bool isRight = true;
    Vector2 Inputmouseposition;
    public Image runhandle;
    public Color color;
    

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        SpriteRend = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x_val = Direction.Horizontal;
        float y_val = Direction.Vertical;
        for (int i=0;i<Input.touchCount; i++)
        {
            if (Input.GetTouch(i).position.x>1500)
            {
                Inputmouseposition = Input.GetTouch(i).deltaPosition;
                if (handle.activeSelf==false)
                {
                    if (Inputmouseposition.x > 0)
                    {
                        transform.Rotate(0, 0, Time.deltaTime * (Inputmouseposition.x * 10), Space.Self);
                    }
                    if (Inputmouseposition.x < 0)
                    {
                        transform.Rotate(0, 0, Time.deltaTime * (Inputmouseposition.x * 10), Space.Self);
                    }
                }
            }
        }
      
        //캐릭터 이동 스크립트
        

        if (speed.run == true)
        {
            runhandle.color = new Color32(255, 255, 255, 255);
        }

        if (speed.run == false)
        {
            runhandle.color = new Color32(255, 255, 255, 140);
        }
        if (x_val != 0||y_val!=0)
        {
            ani.SetBool("walk", true);
        }
        else
            ani.SetBool("walk", false);
        Debug.Log(speed.speed);

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
        float x_val = Direction.Horizontal;
        float y_val = Direction.Vertical;

        transform.Translate(new Vector2(x_val * speed.speed, 0));
            transform.Translate(new Vector2(0, y_val * speed.speed));
        


    }
    
}

