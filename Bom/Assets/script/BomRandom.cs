using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomRandom : MonoBehaviour
{
    float delta;
    float respawnTime;
    public GameObject Bom;
    // Start is called before the first frame update
    void Start()
    {

        respawnTime = 5.0f;
        delta = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(respawnTime <= delta)
        {
            delta = 0.0f;
            if (respawnTime > 2)
            {
                respawnTime -= 0.5f;
            }
            
            GameObject itemBomBullets = Instantiate(Bom) as GameObject;

            float x = Random.Range(-50.0f, 50.0f);
            float y = Random.Range(0.0f, 0.0f);
            float z = Random.Range(-40.0f,40.0f);
            itemBomBullets.transform.position = new Vector3(x, 0.0f, z);

        }
    }
}
