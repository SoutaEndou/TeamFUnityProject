using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bom : MonoBehaviour
{
    public bool flg = false;
   
    // Start is called before the first frame update
    void Start()
    {
        flg = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("playerBullets") || other.CompareTag("bomBullets"))
        {
            flg = true;

            //Destroy(gameObject);
        }
    }
  
}
