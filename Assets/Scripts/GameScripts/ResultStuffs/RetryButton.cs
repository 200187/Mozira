using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RetryButton : MonoBehaviour
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
            if (GrobalInfo.life > 0)
            {
                PushSE.Play();
                Invoke("ChangeScene", 1.0f);
                GrobalInfo.life--;
            }
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
