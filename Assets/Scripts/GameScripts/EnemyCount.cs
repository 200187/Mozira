using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{
    public static int score = 0;
    bool isClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickedMozira()
    {
        if (!isClicked)
        {
            score++;
            Destroy(transform.parent.gameObject.transform.parent.gameObject);
            GameProgression.EnemyExists = false;
        }
        isClicked = true;
    }
    
    public void ClickedHelmet()
    {
        if (!isClicked)
        {
            score++;
            Destroy(transform.parent.gameObject.transform.parent.gameObject);
            GameProgression.EnemyExists = false;
        }
        isClicked = true;
    }
    
    public void ClickedRare()
    {
        if (!isClicked)
        {
            score += 3;
            Destroy(transform.parent.gameObject.transform.parent.gameObject);
            GameProgression.EnemyExists = false;
        }
        isClicked = true;
    }
    
    public void ClickedSnake()
    {
        if (!isClicked)
        {
            score -= 3;
            Destroy(transform.parent.gameObject.transform.parent.gameObject);
            GameProgression.EnemyExists = false;
        }
        isClicked = true;
    }
}
