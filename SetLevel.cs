using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLevel : MonoBehaviour
{
    public int lvl;
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }
    void TaskOnClick()
    {
        ButtonFunctions.setLevel(lvl);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
