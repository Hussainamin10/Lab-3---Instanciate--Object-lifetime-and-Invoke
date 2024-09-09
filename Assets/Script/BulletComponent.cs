using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public float bulletSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

        // Destroy the bullet after 5 seconds
        Destroy(gameObject, 5f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
