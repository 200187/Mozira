using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public static float TimeLimit = 90f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = TimeLimit.ToString("F2");

        if (TimeLimit <= 0)
        {

        }
        else
        {
            TimeLimit -= Time.deltaTime;
        }
    }
}
