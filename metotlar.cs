using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metotlar : MonoBehaviour
{
    void Start()
    {
        toplama(20,30);
    }

    void toplama(int x, int y) //iki parametre
    {
        Debug.Log(x + y);
    }
}
