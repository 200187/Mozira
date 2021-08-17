using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
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
        SceneManager.LoadScene("MenuScene");
    }
}
