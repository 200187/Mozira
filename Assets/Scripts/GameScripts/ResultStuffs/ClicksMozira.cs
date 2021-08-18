using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicksMozira : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string MoziraTotal = GameProgression.ClicksMozira + "•C";
        GetComponent<Text>().text = MoziraTotal;
    }
}
