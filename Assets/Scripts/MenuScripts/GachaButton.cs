using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GachaButton : MonoBehaviour
{
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
            Invoke("ChangeScene", 1.0f);
        }
        isClicked = true;
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("GachaScene");
    }
}
