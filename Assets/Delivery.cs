using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    float destroyDelay = 0.5f;

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Look out");   
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package") {
            Debug.Log("Package acquired");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Customer" && hasPackage) {
            Debug.Log("Package delivered");
            hasPackage = false;
        }
    }
}
