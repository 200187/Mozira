using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DiveReturn : MonoBehaviour
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
        SceneManager.LoadScene("MenuScene");
        Timer.TimeLimit = 5.0f;
        DiveScore.CurrentDiveScore = 0;
        AppearsButton.Appears = false;
    }

}
