using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgression : MonoBehaviour
{
    
    public static bool isFinish = false;
    public static bool EnemyExists = false;

    public static GameObject instance = null;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.TimeLimit>=0)
        {
            if (!EnemyExists)
            {
                GameObject obj = (GameObject)Resources.Load(RandomEnemy());

                switch ((int)Random.Range(1,11))
                { 
                    case 1:
                        instance = (GameObject)Instantiate(obj, new Vector3(156.5f, 353.0f, 0.0f), Quaternion.identity);
                        EnemyExists = true; break;                     
                    case 2:
                        instance = (GameObject)Instantiate(obj, new Vector3(384.5f, 387, 0.0f), Quaternion.identity);
                        EnemyExists = true; break;
                    case 3:
                        instance = (GameObject)Instantiate(obj, new Vector3(655.5f, 411.0f, 0.0f), Quaternion.identity);
                        EnemyExists = true; break;
                    case 4:
                        instance = (GameObject)Instantiate(obj, new Vector3(96.5f, 219.0f, 0.0f), Quaternion.identity);
                        EnemyExists = true; break;
                    case 5:
                        instance = (GameObject)Instantiate(obj, new Vector3(383.5f, 243.0f, 0.0f), Quaternion.identity);
                        EnemyExists = true; break;
                    case 6:
                        instance = (GameObject)Instantiate(obj, new Vector3(605.5f, 285.0f, 0.0f), Quaternion.identity);
                        EnemyExists = true; break;
                    case 7:
                        instance = (GameObject)Instantiate(obj, new Vector3(823.5f, 312.0f, 0.0f), Quaternion.identity);
                        EnemyExists = true; break; 
                    case 8:
                        instance = (GameObject)Instantiate(obj, new Vector3(180.5f, 98.0f, 0.0f), Quaternion.identity);
                        EnemyExists = true; break;
                    case 9:
                        instance = (GameObject)Instantiate(obj, new Vector3(402.5f, 113.0f, 0.0f), Quaternion.identity);
                        EnemyExists = true; break;
                    case 10:
                        instance = (GameObject)Instantiate(obj, new Vector3(632.5f, 111.0f, 0.0f), Quaternion.identity);
                        EnemyExists = true; break;
                    case 11:
                        instance = (GameObject)Instantiate(obj, new Vector3(823.5f, 54.0f, 0.0f), Quaternion.identity);
                        EnemyExists = true; break;
                }
            }
        }
        else
        {
            isFinish = true;
        }

        if (isFinish)
        {

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
