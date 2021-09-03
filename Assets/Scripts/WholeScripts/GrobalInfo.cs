using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrobalInfo : MonoBehaviour
{
    public static float level = 0;
    public static int coin = 10000;
    public static int life = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (life < 5)
        {
            Invoke("AddLife", 300.0f);
        }
    }

    void AddLife()
    {
         life++;
    }
}
