using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    public float speed = 100f;







    public Vector3 pos
    {
        //setters and getters for positions
        get
        {
            return (this.transform.position);
        }
        set
        {
            this.transform.position = value;
        }

    }
    public void Update()
    {

        if (gameObject != null)
        {
            Move();
        }


    }
    public virtual void Move()
    {
        Vector3 tempPos = pos;
        //general movement for enemy if it is not inherited as enemy1 or enemy2
        tempPos.z -= -speed * Time.deltaTime;
        tempPos.y -= -speed * Time.deltaTime;
        pos = tempPos;
    }
}
