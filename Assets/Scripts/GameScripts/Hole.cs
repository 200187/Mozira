using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public static bool EnemyExists = false;
    public static GameObject instance = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!EnemyExists)
        {
            if (Random.Range(0, 100)==0)
            {
                GameObject obj = (GameObject)Resources.Load(RandomEnemy());
                instance = (GameObject)Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity,this.transform);
                EnemyExists = true;
            }
        }
    }

    string RandomEnemy()
    {
        switch (Random.Range(1, 5))
        {
            case 1:
                return "Mozira";
            case 2:
                return "HelmetMozira";
            case 3:
                return "RareMozira";
            case 4:
                return "Snake";
            default:
                return "errer";
        }
    }
}
