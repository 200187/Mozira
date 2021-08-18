using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicksRareMozira : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string RareMoziraTotal = GameProgression.ClicksRareMozira + "•C";
        GetComponent<Text>().text = RareMoziraTotal;
    }
}
