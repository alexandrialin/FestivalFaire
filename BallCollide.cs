using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollide : MonoBehaviour
{
    public GameObject balls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground") && gameObject.CompareTag("Ball"))
        {
            Instantiate(balls, new Vector3(0.39f, 2.056f,-6.67f), Quaternion.identity);
        }
    }
}
