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

        // k�sa y�ntem
        sayac += 5;
        sayac -= 5;
        sayac *= 5;
        sayac /= 5;

        Debug.Log(sayi++); //�nce yazd�r�r sonra art�r�r.
        Debug.Log(++sayi); //�nce art�r�r sonra yazd�r�r.

    }
}
