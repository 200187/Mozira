using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public static int players = 0;
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
        Invoke("ChangeScene", 1.5f);
    }

    public void ClickedMultiPlay()
    {
        players = 2;
        Invoke("ChangeScene", 1.5f);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
