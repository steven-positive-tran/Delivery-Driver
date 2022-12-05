using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 hasPackageColor = new Color(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color(1,1,1,1);
       
    bool hasPackage = false;

    [SerializeField]
    private float pickupDelay = 0.5f;


    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) {

        //Debug.Log("Collision");
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("Trigger Collision");


        if (other.tag == "Package")
        {

            if (!hasPackage)
            {
                Debug.Log("Package Picked Up");
                hasPackage = true;

                spriteRenderer.color = hasPackageColor;
                Destroy(other.gameObject, pickupDelay);

            }

        }
        
        
        
        if (other.tag == "Customer")
        {
            if(hasPackage)
            {
                Debug.Log("Customer");
                hasPackage = false;
                spriteRenderer.color = noPackageColor;
            }

        }


    }

}


