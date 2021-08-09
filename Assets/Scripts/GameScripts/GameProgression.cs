using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgression : MonoBehaviour
{
    public bool isFinish = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.TimeLimit>=0)
        {

        }
        else
        {
            isFinish = true;
        }

        if (isFinish)
        {

        }
    }
}
