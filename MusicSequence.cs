using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicSequence : MonoBehaviour
{
    public GameObject lowC;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;
    public GameObject A;
    public GameObject B;
    public GameObject highC;
    public static int[] notes= { 0, 0, 0,0,0,0};
    public static int[] answers = { 1, 3, 5,6,4,2};
    public static GameObject correct;
    public GameObject setCorrect;
    public static GameObject incorrect;
   public GameObject setIncorrect;
    public GameObject yesNo;

    // Start is called before the first frame update
    void Start()
    {
        
       correct = setCorrect;
       incorrect = setIncorrect;
        print(notes[0] + " " + notes[1] + " " + notes[2]);
        StartCoroutine(Gameplay());

        
    }


    IEnumerator Gameplay()
    {
        for(int i = 0; i < 3; i++)
        {
            System.Random random = new System.Random();


            answers[i]= random.Next(1, 9);
            if (answers[i]==1) { Instantiate(lowC); }
            if (answers[i] == 2) { Instantiate(D); }
            if (answers[i] == 3) { Instantiate(E); }
            if (answers[i] == 4) { Instantiate(F); }
            if (answers[i] == 5) { Instantiate(G); }
            if (answers[i] == 6) { Instantiate(A); }
            if (answers[i] == 7) { Instantiate(B); }
            if (answers[i] == 8) { Instantiate(highC); }
            yield return new WaitForSeconds(.5f);
        }
   /*
        Instantiate(lowC);
        yield return new WaitForSeconds(.5f);
        Instantiate(E);
        yield return new WaitForSeconds(.5f);
        Instantiate(G);
        yield return new WaitForSeconds(.5f);
   */
        

    }

    public  void Sequence(int note)
    {
        print(notes[0] + " " + notes[1] + " " + notes[2]);
        if (notes[0] == 0)
        {
            notes[0] = note;
            print("hello0" + notes[0]);
            

        }
        else if (notes[1] == 0)
        {
            notes[1] = note;
            print("hello1" + notes[1]);

        }
        else if (notes[2] == 0)
        {
            notes[2] = note;
            print("hello2" + notes[2]);
            Correct1();

        }

     


    }

    public void Correct1()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (notes[0]==answers[0]&& notes[1] == answers[1] && notes[2] == answers[2])
        {
            print("hello correct");
            notes[0] = 0;
            notes[1] = 0;
            notes[2] = 0;
            print(notes[0] + " " + notes[1] + " " + notes[2]);
            Points.addthePoints(10);
            
            
        }
        else
        {
            print("hello incorrect");
            notes[0] = 0;
            notes[1] = 0;
            notes[2] = 0;
            print(notes[0]+" " + notes[1]+ " "+notes[2]);
           
            

        }
        
        SceneManager.LoadScene("Piano");


    }


}
