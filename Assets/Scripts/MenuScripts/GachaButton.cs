using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GachaButton : MonoBehaviour
{
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
        Invoke("ChangeScene", 1.5f);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("GachaScene");
    }
}
