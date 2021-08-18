using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    bool isClicked = false;
    int clicks = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = GameProgression.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("RunAway", 1.0f);
    }

    void RunAway()
    {
        Destroy(transform.parent.gameObject.transform.parent.gameObject);
        GameProgression.EnemyExists = false;
    }

    public void ClickedMozira()
    {
        if (!isClicked)
        {
            Scorer.CurrentScore++;
            Destroy(transform.parent.gameObject.transform.parent.gameObject);
            GameProgression.EnemyExists = false;
            GameProgression.ClicksMozira++;
        }
        isClicked = true;
    }

    public void ClickedHelmet()
    {
        clicks++;

        if (clicks >= 2)
        {
            Scorer.CurrentScore++;
            Destroy(transform.parent.gameObject.transform.parent.gameObject);
            GameProgression.EnemyExists = false;
            GameProgression.ClicksHelmetMozira++;
            clicks = 0;
        }
    }

    public void ClickedRare()
    {
        if (!isClicked)
        {
            Scorer.CurrentScore += 3;
            Destroy(transform.parent.gameObject.transform.parent.gameObject);
            GameProgression.EnemyExists = false;
            GameProgression.ClicksRareMozira++;
        }
        isClicked = true;
    }

    public void ClickedSnake()
    {
        if (!isClicked)
        {
            Scorer.CurrentScore -= 3;
            Destroy(transform.parent.gameObject.transform.parent.gameObject);
            GameProgression.EnemyExists = false;
            GameProgression.ClicksSnake++;
        }
        isClicked = true;
    }
}
