using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallData
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
    // BallData�̃R���X�g���N�^
    public BallData(int hitPoint)
    {
        this.hitPoint = hitPoint;
    }

}
