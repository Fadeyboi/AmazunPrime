using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float slowSpeed;
    [SerializeField] private float boostSpeed;

    void Update()
    {
        float rotateAmount = Input.GetAxis("Horizontal") * (rotateSpeed * moveSpeed) * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotateAmount);
        transform.Translate(0, speedAmount, 0);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Booster")
        {
            moveSpeed = boostSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;
    }

}
