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
            Debug.Log("Ya�1, ya�2'den b�y�k.");
        }
        if (yas1 < yas2)
        {
            Debug.Log("Ya�2, Ya�1'den b�y�k.");
        }
        else
        {
            Debug.Log("Ya�lar e�it.");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) && can>0) //mouse'un sol tu�u (0), sa� tu�u(1)
        {
            can = can - 10; 
            Debug.Log(can);
        }
        if (can == 0)
        {
            Debug.Log("�ld�n�z :(");
        }
    }
}
