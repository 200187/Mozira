using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneHammer : MonoBehaviour
{
    bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void isCliked()
    {
        if (!isClicked && Storage.unknownHammer[1])
        {
            HammerText.Text = "Stone Hammer";
        }
        
    }
}
