using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prizes : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        if (Points.displayPoints() <= 10)
        {
            text.text = "A small sheep";

        }
        if (Points.displayPoints() > 20 && Points.displayPoints()<30)
        {
            text.text = "A medium cat";

        }
        if (Points.displayPoints() >40)
        {
            text.text = "A large duck";

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
