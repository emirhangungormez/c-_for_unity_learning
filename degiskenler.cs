using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class degiskenler : MonoBehaviour
{
    void Start()
    {
        //deðiþken türleri
        int sayi = 15; //tam sayýlar
        int sayi2 = 10;
        float sayi3 = 15.2f; //ondalýklý sayýlar
        bool kontrol = true; //koþul
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
