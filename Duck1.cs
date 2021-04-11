using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck1 : DuckMovement
{
    public override void Move()
    {
        //enemy 1 moves in downward direction
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;

    }
}