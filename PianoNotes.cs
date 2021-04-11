using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PianoNotes : MonoBehaviour
{
    public Button yourButton;
    public GameObject note;
    MusicSequence ms = new MusicSequence();

    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {

        Instantiate(note);
        if (gameObject.CompareTag("LowC"))
        {
            ms.Sequence(1);
        }
        if (gameObject.CompareTag("D"))
        {
            ms.Sequence(2);
        }
        if (gameObject.CompareTag("E"))
        {
            ms.Sequence(3);
        }
        if (gameObject.CompareTag("F"))
        {
            ms.Sequence(4);
        }
        if (gameObject.CompareTag("G"))
        {
            ms.Sequence(5);
        }
        if (gameObject.CompareTag("A"))
        {
            ms.Sequence(6);
        }
        if (gameObject.CompareTag("B"))
        {
            ms.Sequence(7);
        }
        if (gameObject.CompareTag("HighC"))
        {
            ms.Sequence(8);
        }



    }
}
