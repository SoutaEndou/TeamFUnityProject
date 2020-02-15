using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class BomBulletMub : MonoBehaviour
{
    public GameObject plane;
    Vector3 moveDir;    // 移動方向ベクトル
    float speed = 0.2f; // 移動速度


    private GameObject wall;

    void Start()
    {
        moveDir = new Vector3(1, 0, 0).normalized * speed;
        wall = GameObject.FindGameObjectWithTag("wall");
    }

    void Update()
    {
        // 移動
        transform.position += moveDir;

        //ボールと平面の距離

        Vector3 d = transform.position - wall.transform.position;
        float h = Vector3.Dot(d, wall.transform.up);

        // 当たり判定
        if (h < transform.localScale.x)
        {
            Collision();
        }
    }

    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.tag =="wall")
    //    {
    //        Debug.Log("AAAAAA");
    //        Vector3 n = other.transform.up;
    //        float h = Mathf.Abs(Vector3.Dot(moveDir, n));
    //        Vector3 r = moveDir + 2 * n * h;
    //        //Vector3 r = moveDir * -1;
    //        Debug.Log(n);
    //        Debug.Log(h);
    //        Debug.Log(r);
    //        moveDir = r;
    //        //Collision();
    //    }
    //}

    void Collision()
    {
        // 反射ベクトルを計算する
        //Vector3 n = plane.transform.up;
        //float h = Mathf.Abs(Vector3.Dot(moveDir, n));
        //Vector3 r = moveDir + 2 * n * h;
        //moveDir = r;
    }

}

