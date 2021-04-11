using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck2 : DuckMovement
{


    public override void Move()
    {

        Vector3 tempPos = pos;
        //based on direction tag given to enemy, go that direction
        if (gameObject.CompareTag("left"))
        {
            tempPos.y -= speed * Time.deltaTime;
            tempPos.x -= -speed * Time.deltaTime;

        }
        if (gameObject.CompareTag("right"))
        {
            tempPos.y -= speed * Time.deltaTime;
            tempPos.x -= speed * Time.deltaTime;

        }
        pos = tempPos;


    }

}
