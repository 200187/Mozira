using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerHit : MonoBehaviour
{
    public static bool hammerHit = false;
    public GameObject hammer;

    // Start is called before the first frame update
    void Start()
    {
        hammer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        
        if (hammerHit)
        {
            hammer.SetActive(true);
            Invoke("DisPlay", 0.5f);
            hammerHit = false;
        }
    }

    void DisPlay()
    {
        hammer.SetActive(false);
    }

}
