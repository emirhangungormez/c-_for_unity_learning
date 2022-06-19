using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donguler : MonoBehaviour
{
    void Start()
    {
        /* int sayac = 0;
        while (sayac < 10)
        {
            Debug.Log(sayac);
            sayac++;
        }

        for (int i = 0; i < 10; i++);
        {
            Debug.Log(i);
        } */

        for (int i = 0; i < 50; i++)
        {
            if (i%2==0)
            {
                Debug.Log(i + " bir çift sayýdýr.");
            }

            if (i == 30)
            {
                break;
            }
        }
    }

    void Update()
    {
        
    }
}
