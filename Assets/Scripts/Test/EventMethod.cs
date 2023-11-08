using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMethod : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Startより前に1回だけ実行される");
    }
    private void Start()
    {
        Debug.Log("Awakeが全て処理された後に1回だけ実行される");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
