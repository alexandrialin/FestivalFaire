using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    public Button shoot;
    public GameObject balllow;
    public GameObject ballmed;
    public GameObject ballhi;
    public static int level;
    // Start is called before the first frame update
    void Start()
    {
        Points.resetPoints();
        Button btn = shoot.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);


    }
    public static void setLevel(int lvl)
    {
        level = lvl;
    }
    void TaskOnClick()
    {

            print(level);


            if (level == 1) {
            print("low");
            GameObject childObject = Instantiate(balllow, new Vector3(0.346f, 2,-5f), Quaternion.identity) as GameObject;
            childObject.transform.parent = gameObject.transform;
            Instantiate(balllow);
        }
            if (level == 2)
            {
            GameObject childObject = Instantiate(ballmed, new Vector3(0.346f, 2, -5f), Quaternion.identity) as GameObject;
            childObject.transform.parent = gameObject.transform;
        }
            if (level == 3)
            {
            GameObject childObject = Instantiate(ballhi, new Vector3(0.346f, 2, -5f), Quaternion.identity) as GameObject;
            childObject.transform.parent = gameObject.transform;
        }
        
    
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
