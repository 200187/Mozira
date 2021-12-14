using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    public static bool[] unknownHammer = new bool [6];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        unknownHammer[0] = true;
        unknownHammer[1] = true;
    }
}
