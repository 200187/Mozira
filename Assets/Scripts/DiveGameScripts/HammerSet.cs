using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSet : MonoBehaviour
{
    public static bool hammerSet = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!hammerSet)
        {
            Invoke("Hit",0.2f);
            transform.position = new Vector3(275f, 400f, -5f);
            hammerSet = true;
        }
    }
    void Hit()
    {
        transform.position = new Vector3(300f, 350f, -5f);
    }
}



