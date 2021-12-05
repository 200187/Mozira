using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearsButton : MonoBehaviour
{
    public static bool Appears = false;
    public static int probabillty = 0;

    [SerializeField] private GameObject canvass;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    { 
        if (Appears)
        {
            probabillty++;
            if (probabillty % 120 == 0)
            {
                Probability();      
            }
                DiveScore.CurrentDiveScore += 00000.5f;
        }
    }


    public void OnButtonDown()
    {
        Appears = true;
    }


    public void OnButtonUp()
    {
        Appears = false;
        RiskText.riskProbability = false;
        CancelInvoke("Minus");
    }

    void Probability()
    {
       
        if ((int)Random.Range(1, 10)==1)
        {
            RiskText.riskProbability = false;
        }
        else
        {
            RiskText.riskProbability = true;
            Invoke("Minus", 1);
        }
    }

    void Minus()
    {
        HammerSet.hammerSet = false;
        HammerHit.hammerHit = true;
        HealthText.health--;
        RiskText.riskProbability = false;
        if (HealthText.health==0)
        {
            Invoke("ToResult", 1.0f);
        }
    }

    

}


