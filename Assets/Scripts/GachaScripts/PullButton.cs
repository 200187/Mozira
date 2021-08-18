using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullButton : MonoBehaviour
{
    [SerializeField] private AudioSource PushSE;
    bool isClicked = false;
   
    [SerializeField] private GameObject Wallpaper;
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
        PushSE.Play();
        Invoke("PullGacha", 1.0f);   
    }

    void PullGacha()
    {
        if (!isClicked)
        {
            if (GrobalInfo.coin >= 200)
            { 
                    Destroy(transform.root.gameObject);
                    GameObject obj = (GameObject)Resources.Load("UIs/GachaPrefab");
                    Instantiate(obj, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity);
                    GrobalInfo.coin -= 200;
                
            }
        }
        isClicked = true;
    }
}
