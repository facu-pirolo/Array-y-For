using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboManagers : MonoBehaviour
{
    public cuboscript[] cubos;
    
    // Start is called before the first frame update
    void Start()
    {
        cubos = FindObjectsOfType<cuboscript>();

        for (int i = 0; i < cubos.Length; i++)
        {
            if (!cubos[i].isPersistent)
            {
                Destroy(cubos[i].gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
