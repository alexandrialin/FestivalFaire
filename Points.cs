using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private static int points = 0;
    public Text text;

    void Start()
    {
        text.text = "Score:" + displayPoints();
    }
    void Update()
    {
        text.text = "Score:" + displayPoints();
    }
    public static int displayPoints()
    {
        return points;
    }

    public static void addthePoints(int p)
    {

        points = points + p;



    }

    public static void resetPoints()
    {
        points = 0;
    }
}

