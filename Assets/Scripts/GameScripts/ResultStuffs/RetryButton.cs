using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RetryButton : MonoBehaviour
{
    [SerializeField] private AudioSource PushSE;
    public static int players = 0;
    bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void ClickedSinglePlay()
    {
        players = 1;
        if (!isClicked)
        {
            PushSE.Play();
            Invoke("ChangeScene", 1.0f);
 
        }
        isClicked = true;
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("GameScene");
        Scorer.CurrentScore = 0;
        Timer.TimeLimit = 5.0f;
    }
}
