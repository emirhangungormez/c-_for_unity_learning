using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siniflar : MonoBehaviour
{
    void Start()
    {
        matematik mat = new matematik();
        Debug.Log(mat.metin);
        Debug.Log(mat.toplama(101,11));
        Debug.Log(mat.carpma(101, 11));
        Debug.Log(mat.bolme(101, 11));
        Debug.Log(mat.c�karma(101, 11));

        GameObject obje = new GameObject(); //UnityEngine paketinde yer alan bir s�n�f
    }

    void Update()
    {
        
    }
}

class matematik
{
    public string metin = "matematik s�n�f�na ho�geldiniz.";
    public int toplama(int a, int b)
    {
        return a +b;
    }

    public int carpma(int a, int b)
    {
        return a * b;
    }

    public int c�karma(int a, int b)
    {
        return a - b;
    }

    public int bolme(int a, int b)
    {
        return a / b;
    }
}
