using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
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
            Invoke("ChangeScene", 1.0f);
        }
        isClicked = true;
    }

    public void ClickedMultiPlay()
    {
        players = 2;
        if (!isClicked)
        {
            Invoke("ChangeScene", 1.0f);
        }
        isClicked = true;
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
