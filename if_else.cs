using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_else : MonoBehaviour
{
    int can = 100;
    void Start()
    {
        int yas1 = 21;
        int yas2 = 30;

        if (yas1 > yas2)
        {
            Debug.Log("Yaþ1, yaþ2'den büyük.");
        }
        if (yas1 < yas2)
        {
            Debug.Log("Yaþ2, Yaþ1'den büyük.");
        }
        else
        {
            Debug.Log("Yaþlar eþit.");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) && can>0) //mouse'un sol tuþu (0), sað tuþu(1)
        {
            can = can - 10; 
            Debug.Log(can);
        }
        if (can == 0)
        {
            Debug.Log("Öldünüz :(");
        }
    }
}
