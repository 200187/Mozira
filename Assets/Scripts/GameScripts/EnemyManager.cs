using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
   int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = GameProgression.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
         count++;
        if (count>=60)
        {
            Destroy(transform.parent.gameObject.transform.parent.gameObject);
            GameProgression.EnemyExists = false;
        }
    }
}
