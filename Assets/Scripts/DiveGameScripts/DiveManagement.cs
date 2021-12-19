using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiveManagement : MonoBehaviour
{
    bool isFinish = false;
    bool continues = false;
    [SerializeField] private GameObject canvass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Timer.TimeLimit <= 0)
        {
            isFinish = true;
        }

        if (HealthText.health <= 0)
        {
            isFinish = true;
        }

            if (isFinish&&!continues)
            {
                
                    Invoke("ToResult", 0.1f);
                    continues = true;
            }
    }
    void ToResult()
        {
            Destroy(canvass.gameObject);
            GameObject obj = (GameObject)Resources.Load("UIs/DiveResultPrefab");
            Instantiate(obj, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity);
            GrobalInfo.coin += 200;
            GrobalInfo.level += 0.5f;
        }
}
