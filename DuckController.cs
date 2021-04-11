using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject currEnemy;
    public int direction;
    public GameObject theEnemy;
    // Start is called before the first frame update
    void Start()
    {
        //spawn enemy to start
        SpawnEnemy();
        Points.resetPoints();



    }

    //pause between spawning
    IEnumerator pause()
    {

        yield return new WaitForSeconds(1);
        SpawnEnemy();


    }

    //method to spawn enemy
    void SpawnEnemy()
    {
        System.Random random = new System.Random();
        //randomize which enemy to spawn, 1 or 2
        currEnemy = enemyPrefabs[random.Next(0, 2)];
        //randomize direction for enemy 2, left or right
        direction = random.Next(0, 2);
        //spawn enemy 1
        if (currEnemy == enemyPrefabs[0])
        {
            theEnemy = Instantiate(currEnemy, new Vector2(random.Next(200, 1200), 800), Quaternion.Euler(0, 90, 0));
        }
        //spawn enemy 2
        if (currEnemy == enemyPrefabs[1])
        {
            //if direction is left set starting position left
            if (direction == 0)
            {
                theEnemy = Instantiate(currEnemy, new Vector2(500, 800), Quaternion.Euler(0,180,0));
                //set gameobject tag as left, will be used in other class
                theEnemy.gameObject.tag = "left";
            }
            //if direction is right set starting position right
            if (direction == 1)
            {
                theEnemy = Instantiate(currEnemy, new Vector2(1400, 800), Quaternion.Euler(0, 270, 0));
                //set  gameobject tag as right, will be used in other class
                theEnemy.gameObject.tag = "right";
            }

        }


        //pause method between spawns
        StartCoroutine(pause());


    }
}
