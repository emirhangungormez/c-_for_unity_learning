using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islemler : MonoBehaviour
{
    int sayac = 0;
    int sayi = 1;
    void Start()
    {
        sayac = sayac + 5;
        sayac = sayac - 5;
        sayac = sayac * 5;
        sayac = sayac / 5;

        // kýsa yöntem
        sayac += 5;
        sayac -= 5;
        sayac *= 5;
        sayac /= 5;

        Debug.Log(sayi++); //önce yazdýrýr sonra artýrýr.
        Debug.Log(++sayi); //önce artýrýr sonra yazdýrýr.

    }
}
