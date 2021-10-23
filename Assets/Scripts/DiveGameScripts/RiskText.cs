using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiskText : MonoBehaviour
{
    public static string risk = "";
    public static int count = 0;
    public static bool riskProbability = false;
    // Start is called before the first frame update
    void Start()
    {
        risk = "SAFE";
    }

    // Update is called once per frame
    void Update()
    {
        if (riskProbability)
        {
            risk = "Danger";
            GetComponent<Text>().text = risk.ToString();
            
        }
        if (!riskProbability)
        {
            risk = "SAFE";
            GetComponent<Text>().text = risk.ToString();
          
        }

    }

  

}