using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shooting : MonoBehaviour
{
    public Rigidbody projectile;

    public float speed = 100;
    public Button yourButton;



    // Use this for initialization
    void Start()
    {
        Points.resetPoints();
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }
    void TaskOnClick()
    {
        print("hi");
        Rigidbody instantiatedProjectile = Instantiate(projectile,
                                                            transform.position,
                                                            transform.rotation)
                 as Rigidbody;

        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(-speed, 0,0));

    }
    // Update is called once per frame
    void Update()
    {



        }
    }
