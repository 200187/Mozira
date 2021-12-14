using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWoodHammer : MonoBehaviour
{
    [SerializeField] private int num;
    public GameObject hammer;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            if (GachaPrefabManagement.unknownHammer[i]&&!GachaPrefabManagement.unknownHammer[1])
            {
                //hammer.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
