using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class component : MonoBehaviour
{
    void Start()
    {
        Rigidbody fizik = GetComponent<Rigidbody>();
        fizik.useGravity = false; //yer çekimini kapatýr.

        Collider col = GetComponent<Collider>();
        col.isTrigger = true; //etkileþimsizliði açar.
    }

    void Update()
    {
        
    }
}
