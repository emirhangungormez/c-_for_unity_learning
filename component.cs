using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class component : MonoBehaviour
{
    void Start()
    {
        Rigidbody fizik = GetComponent<Rigidbody>();
        fizik.useGravity = false; //yer �ekimini kapat�r.

        Collider col = GetComponent<Collider>();
        col.isTrigger = true; //etkile�imsizli�i a�ar.
    }

    void Update()
    {
        
    }
}
