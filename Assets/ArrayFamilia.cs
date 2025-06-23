using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayFamilia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] edades = { 75, 72, 45, 43, 18, 15 }; 

        // Escribir el primer elemento del array
        Debug.Log("Primer elemento: " + edades[0]);

        // Escribir la cantidad de elementos del array
        Debug.Log("Cantidad de elementos: " + edades.Length);

        // Escribir cada elemento del array
        Debug.Log("Todos los elementos:");
        for (int i = 0; i < edades.Length; i++)
        {
            Debug.Log(edades[i]);
        }

        // Escribir el promedio de los elementos del array
        int suma = 0;
        for (int i = 0; i < edades.Length; i++)
        {
            suma += edades[i];
        }
        float promedio = (float)suma / edades.Length;
        Debug.Log("Promedio: " + promedio);

        // Escribir los elementos mayores que 20
        Debug.Log("Elementos mayores que 20:");
        for (int i = 0; i < edades.Length; i++)
        {
            if (edades[i] > 20)
            {
                Debug.Log(edades[i]);
            }
        }

        // Escribir los elementos en orden inverso
        Debug.Log("Elementos en orden inverso:");
        for (int i = edades.Length - 1; i >= 0; i--)
        {
            Debug.Log(edades[i]);
        }
    }
}