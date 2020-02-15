using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADD : MonoBehaviour
{
    Rigidbody rb;
    float x;
    float y;
    float z;
    float delta;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 20/*, ForceMode.Force*/);
    }
    void Update()
    {
        //x = Random.Range(0.0f, 100.0f);
        //y = Random.Range(0.0f, 100.0f);
        //z = Random.Range(0.0f, 100.0f);
        
        this.delta += Time.deltaTime;
        if (delta >= 2.0f)
        {
            delta = 0.0f;
            Destroy(gameObject);
        }
    }
}
