using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Look out");   
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Witty message");
    }
}
