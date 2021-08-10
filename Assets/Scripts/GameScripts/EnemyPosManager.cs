using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPosManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        transform.position=GameProgression.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
