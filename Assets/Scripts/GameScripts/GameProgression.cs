using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgression : MonoBehaviour
{

    public static bool isFinish = false;
    public static bool EnemyExists = false;
    bool Continue = false;

    public static GameObject instance = null;
    [SerializeField] private GameObject canvas;

    public static int ClicksMozira = 0;
    public static int ClicksHelmetMozira = 0;
    public static int ClicksRareMozira = 0;
    public static int ClicksSnake = 0;

    // Start is called before the first frame update
    void Start()
    {
        isFinish = false;
        EnemyExists = false;
        ClicksMozira = 0;
        ClicksHelmetMozira = 0;
        ClicksRareMozira = 0;
        ClicksSnake = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Timer.TimeLimit >= 0)
        {
            if (!EnemyExists)
            {
                EnemyExists = true;
                Invoke("RandomHole", 0.7f);
               
              
            }
            isFinish = false;
        }
        else
        {
            isFinish = true;
        }

        if (isFinish)
        {
            if (!Continue)
            {
                Invoke("ToResult", 1.0f);
                Continue = true;
            }
        }
    }

    string RandomEnemy()
    {
        switch (Random.Range(1, 5))
        {
            case 1:
                return "Enemys/Mozira";
            case 2:
                return "Enemys/HelmetMozira";
            case 3:
                return "Enemys/RareMozira";
            case 4:
                return "Enemys/Snake";
            default:
                return "errer";
        }
    }
    void ToResult()
    {
        
        Destroy(canvas.gameObject);
        GameObject obj = (GameObject)Resources.Load("UIs/ResultPrefab");
        Instantiate(obj, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity);
       
    }

    void RandomHole()
    {
        GameObject obj = (GameObject)Resources.Load(RandomEnemy());
        switch ((int)Random.Range(1, 12))
        {
            case 1:
                instance = (GameObject)Instantiate(obj, new Vector3(156.5f, 353.0f, 0.0f), Quaternion.identity);
                break;
            case 2:
                instance = (GameObject)Instantiate(obj, new Vector3(384.5f, 387, 0.0f), Quaternion.identity);
                 break;
            case 3:
                instance = (GameObject)Instantiate(obj, new Vector3(655.5f, 411.0f, 0.0f), Quaternion.identity);
                 break;
            case 4:
                instance = (GameObject)Instantiate(obj, new Vector3(96.5f, 219.0f, 0.0f), Quaternion.identity);
                 break;
            case 5:
                instance = (GameObject)Instantiate(obj, new Vector3(383.5f, 243.0f, 0.0f), Quaternion.identity);
                 break;
            case 6:
                instance = (GameObject)Instantiate(obj, new Vector3(605.5f, 285.0f, 0.0f), Quaternion.identity);
                 break;
            case 7:
                instance = (GameObject)Instantiate(obj, new Vector3(823.5f, 312.0f, 0.0f), Quaternion.identity);
                break;
            case 8:
                instance = (GameObject)Instantiate(obj, new Vector3(180.5f, 98.0f, 0.0f), Quaternion.identity);
                 break;
            case 9:
                instance = (GameObject)Instantiate(obj, new Vector3(402.5f, 113.0f, 0.0f), Quaternion.identity);
                 break;
            case 10:
                instance = (GameObject)Instantiate(obj, new Vector3(632.5f, 111.0f, 0.0f), Quaternion.identity);
                 break;
            case 11:
                instance = (GameObject)Instantiate(obj, new Vector3(823.5f, 194.0f, 0.0f), Quaternion.identity);
                break;
        }
    }
}

