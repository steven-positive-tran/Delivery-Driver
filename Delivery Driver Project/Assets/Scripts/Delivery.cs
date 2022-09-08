using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
       
    bool hasPackage = false;

    private void OnCollisionEnter2D(Collision2D other) {

        Debug.Log("Collision");
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("Trigger Collision");


        if (other.tag == "Package")
        {
            Debug.Log("Package Picked Up");
            hasPackage = true;
        }
        
        
        
        if (other.tag == "Customer")
        {
            Debug.Log("Customer");
            hasPackage = false;
        }


    }


}


