using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSet : MonoBehaviour
{
    public static bool hammerSet = true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!hammerSet)
        {
            gameObject.SetActive(false);
            hammerSet = true;
            Invoke("Display", 0.5f);


        }
    }
    void Display()
    {
        gameObject.SetActive(true);
    }
}

