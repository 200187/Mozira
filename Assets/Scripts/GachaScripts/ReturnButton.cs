using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReturnButton : MonoBehaviour
{
    [SerializeField] private AudioSource PushSE;
    bool isClicked = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clicked()
    {
        if (!isClicked)
        {
            PushSE.Play();   
            Invoke("ChangeScene", 1.0f);
        }
        isClicked = true;
    }

    void ChangeScene()
    {
        if (Scoresave.one < Scorer.CurrentScore)
        {
            Scoresave.five = Scoresave.fourth;
            Scoresave.fourth = Scoresave.three;
            Scoresave.three = Scoresave.two;
            Scoresave.two = Scoresave.one;
            Scoresave.one = Scorer.CurrentScore;
        }
        else if (Scoresave.two < Scorer.CurrentScore)
        {
            Scoresave.five = Scoresave.fourth;
            Scoresave.fourth = Scoresave.three;
            Scoresave.three = Scoresave.two;
            Scoresave.two = Scorer.CurrentScore;
        }
        else if (Scoresave.three < Scorer.CurrentScore)
        {
            Scoresave.five = Scoresave.fourth;
            Scoresave.fourth = Scoresave.three;
            Scoresave.three = Scorer.CurrentScore;
        }
        else if (Scoresave.fourth < Scorer.CurrentScore)
        {
            Scoresave.five = Scoresave.fourth;
            Scoresave.fourth = Scorer.CurrentScore;
        }
        else if (Scoresave.five < Scorer.CurrentScore)
        {
            Scoresave.five = Scorer.CurrentScore;
        }
        SceneManager.LoadScene("MenuScene");
        Scorer.CurrentScore = 0;
        Timer.TimeLimit = 5.0f;
    }
}
