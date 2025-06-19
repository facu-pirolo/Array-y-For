using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{
    int[] numeros = { 1, 2, 3, 4 } ;
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
        //Escribir los multiplos de tre inclusive el 30
        for (int i = 3; i <= 30; i += 3)
        {
            Debug.Log(i);
        }
        for (int i = num1; i <= num2; i++)
        {
            Debug.Log(i);
        }
        for (int i = 25; i >= 4; i--)
        {
            if(i == 13)
            {
                continue;
            }
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
