using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
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

        if (!isClicked)
        {
            if (GrobalInfo.life > 0)
            {
                players = 1;
                PushSE.Play();
                Invoke("ChangeScene", 1.0f);
                GrobalInfo.life--;
            }
        }
        isClicked = true;
    }

    public void ClickedMultiPlay()
    {
        players = 2;
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
    }
}
