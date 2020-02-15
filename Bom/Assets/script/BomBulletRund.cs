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

    int rndm;

    Bom bom;
    // Start is called before the first frame update
    void Start()
    {
        bom = GameObject.Find("Bom").GetComponent<Bom>();
        if (bom.flg)
        {

        }
        rndm = 0;
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
        bom = GameObject.Find("Bom").GetComponent<Bom>();
        if (bom.flg)
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
                float rx = Random.Range(0.0f, -721.0f);
                float ry = Random.Range(0.0f, 91.0f);
                float rz = Random.Range(0.0f, -10.0f);

                rndm = Random.Range(1, 4);
                if (rndm == 1)
                {
                    itemBomBullets.transform.Rotate(0.0f, ry, 0.0f);
                }
                else if (rndm == 2)
                {
                    itemBomBullets.transform.Rotate(0.0f, rx, 0.0f);
                }
                else if (rndm == 3)
                {
                    itemBomBullets.transform.Rotate(0.0f, rz, 0.0f);
                }


                   


            }
            
        }

        if (bulletVolume <= 0)
        {
            Destroy(gameObject);
        }
    }

}
