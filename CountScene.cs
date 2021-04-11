using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountScene : MonoBehaviour
{
    static int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Counter();
    }
        void Counter()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        count++;
        if (count == 5)
        {
            SceneManager.LoadScene("Prizes");
        }
       
    } 
}
