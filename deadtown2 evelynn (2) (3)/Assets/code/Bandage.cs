using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandage : MonoBehaviour
{
    public class insoeng: human
    {
        public void ghhg()
        {
            Debug.Log("나는"+age+"살");
            Debug.Log("내 성별은" + sex);
        }
        public int age;
        public string name;
    }

    public class human
    {
        public string sex;

    }

    // Start is called before the first frame update
    void Start()
    {

        insoeng sang = new insoeng();
        insoeng a = new insoeng();
        a.age = 19;
        a.name = "wef";
        sang.age=17;
        sang.name="정상수";
        a = sang;
        a.name = "pp";
        a.sex = "man";
        sang.sex = "man";


        a.ghhg();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
