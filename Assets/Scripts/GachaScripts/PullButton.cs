using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullButton : MonoBehaviour
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
        Invoke("PullGacha", 1.0f);   
    }

    void PullGacha()
    {
        if (!isClicked)
        {
            if (GrobalInfo.coin >= 200)
            {
                GameObject obj = (GameObject)Resources.Load("UIs/GachaPrefab");
                Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                Destroy(transform.root.gameObject);
                GrobalInfo.coin -= 200;
            }
        }
        isClicked = true;
    }
}
