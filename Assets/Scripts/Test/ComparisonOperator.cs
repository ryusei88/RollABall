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
            Debug.Log("xÇÕyÇÊÇËëÂÇ´Ç¢");
        }

        string name1 = "john";
        string name2 = "john";
        if(name1 == name2)
        {
            Debug.Log("ìÒÇ¬ÇÃñºëOÇÕìØÇ∂Ç≈Ç∑");
        }

        int age = 0;
        if(age >= 20)
        {
            Debug.Log("ê¨êlÇ≈Ç∑");
        }
        else
        {
            Debug.Log("ñ¢ê¨îNÇ≈Ç∑");
        }
    }

   
}
