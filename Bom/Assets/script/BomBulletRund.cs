using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomBulletRund : MonoBehaviour
{
    public Transform myTransform;
    public GameObject BomBullets;
    Vector3 bomPos;
    float span;
    float delta;
    int bulletVolume;
    // Start is called before the first frame update
    void Start()
    {

        myTransform = this.transform;
        bomPos = myTransform.position;
        bulletVolume = 50;
        delta = 0.0f;
        span = 0.00001f;
    }

    // Update is called once per frame
    //void BulletRand()
    //{
    //    this.delta += Time.deltaTime;
    //    if (this.delta > this.span && bulletVolume > 0)
    //    {
    //        bulletVolume--;
    //        this.delta = 0;
    //        GameObject itemBomBullets = Instantiate(BomBullets) as GameObject;
    //        float x = bomPos.x;
    //        float y = bomPos.y;
    //        float z = bomPos.z;
    //        itemBomBullets.transform.position = new Vector3(x, y, z);
    //        float ry = Random.Range(0.0f, 360.0f);
    //        itemBomBullets.transform.Rotate(0.0f, ry, 0.0f);



    //    }

    //}
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span && bulletVolume > 0)
        {
            bulletVolume--;
            this.delta = 0;
            GameObject itemBomBullets = Instantiate(BomBullets) as GameObject;
            float x = bomPos.x;
            float y = bomPos.y;
            float z = bomPos.z;
            itemBomBullets.transform.position = new Vector3(x, y, z);
            float ry = Random.Range(0.0f, -720.0f);
            itemBomBullets.transform.Rotate(0.0f, ry, 0.0f);



        }
    }
}
