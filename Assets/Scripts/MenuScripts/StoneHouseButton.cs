using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StoneHouseButton : MonoBehaviour
{
    [SerializeField] private AudioSource PushSE;
    [SerializeField] private GameObject canvas;
    bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        if (!isClicked)
        {
            PushSE.Play();
            Invoke("ToStoneHouse", 1.0f);
        }
        isClicked = true;
    }

    void ToStoneHouse()
    {
        Destroy(canvas.gameObject);
        GameObject obj = (GameObject)Resources.Load("UIs/StoragePrefab");
        Instantiate(obj, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity);
    }
}
