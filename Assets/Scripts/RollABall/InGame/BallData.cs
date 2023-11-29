using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallData : MonoBehaviour
{
    private int hitPoint;
    public int GetHitPoint
    {
        get { return hitPoint; }
    }
    public int SetHitPoint
    {
        set { hitPoint = value; }
    }
    // BallDataのコンストラクタ
    public BallData(int hitPoint)
    {
            this.hitPoint = hitPoint;
    }
}
