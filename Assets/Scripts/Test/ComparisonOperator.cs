using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 5;
        int y = 0;
        if(x > y)
        {
            Debug.Log("xはyより大きい");
        }

        string name1 = "john";
        string name2 = "john";
        if(name1 == name2)
        {
            Debug.Log("二つの名前は同じです");
        }

        int age = 0;
        if(age >= 20)
        {
            Debug.Log("成人です");
        }
        else
        {
            Debug.Log("未成年です");
        }
    }

   
}
