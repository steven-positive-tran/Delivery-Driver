using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 0.1f;
    [SerializeField]float moveSpeed = 0.01f;
    [SerializeField]float slowSpeed = 0.0075f;
    [SerializeField]float boostSpeed = 0.02f;

    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boosts")
        {
            moveSpeed = boostSpeed;
        }
        else if (collision.gameObject.tag == "Bumps")
        {
           moveSpeed = slowSpeed;
        }
        else if (collision.gameObject.tag == "Collision")
        {
            moveSpeed = 0.01f;
        }
    }

}
