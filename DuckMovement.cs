using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuckMovement : MonoBehaviour
{




    public GameObject Hero;
 
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
        tempPos.x -= speed * Time.deltaTime;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }
    private void OnTriggerEnter(Collider other)
    {
        //if enemy collides with hero, destroy both game objects
        if (other.gameObject.CompareTag("Hero"))
        {

            Destroy(other.gameObject);
            Destroy(gameObject);


        }
    }

     void OnMouseDown()
    {
        gameObject.SetActive(false);
        Points.addthePoints(1);
        
    }
}

