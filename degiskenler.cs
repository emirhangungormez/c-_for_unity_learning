using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class degiskenler : MonoBehaviour
{
    void Start()
    {
        //de�i�ken t�rleri
        int sayi = 15; //tam say�lar
        int sayi2 = 10;
        float sayi3 = 15.2f; //ondal�kl� say�lar
        bool kontrol = true; //ko�ul
        string metin = "emir"; //metin

        int toplam;
        toplam = sayi + sayi2;

        Debug.Log(sayi3);
        Debug.Log(toplam);
        Debug.Log(kontrol);
        Debug.Log(metin);
    }

    void Update()
    {
        
    }
}
