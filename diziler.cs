using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diziler : MonoBehaviour
{
    void Start()
    {
        //dizi g�sterimi - 1
        int[] dizi = new int[100];
        int i;

        for (i = 0; i < dizi.Length; i++)
        {
            dizi[i] = i;
        }

        for (i = 0; i < dizi.Length; i++)
        {
            Debug.Log(dizi[i]);
        }

        //dizi g�sterimi - 2
        int[] dizi2 = { 15, 25, 35 };

        for (int j = 0; j < dizi.Length; j++)
        {
            Debug.Log(dizi2[j]);
        }

        //dizi g�sterimi - 3
        string[] isimler = new string[3];
        isimler[0] = "emir";
        isimler[1] = "han";
        isimler[2] = "g�ng�rmez";

        for (int m = 0; m < dizi.Length; m++)
        {
            Debug.Log(isimler[m]);
        }
    }
}