using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePressStartScript : MonoBehaviour
{
    //点滅するスピード
    public float TransperSpeed = 1.0f;
    public float StartTimeEnd = 5.0f;

    private SpriteRenderer spRenderer;
    private float TransperTime;
    private float Color_Arufa;
    private bool StartSwitch = false;
    private float StartTime;
    private bool Transparent = false;


    // Start is called before the first frame update
    void Start()
    {
        spRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //点滅させる
        var Color = spRenderer.color;
        if(Transparent == false)
        {
            TransperTime += Time.deltaTime * 5.0f * TransperSpeed;
            Color_Arufa = Mathf.Sin(TransperTime) * 0.5f + 0.5f;
        }

        if (StartSwitch == true)
        {
            //ボタン押されて一定時間経ったら透明にする
            StartTime += Time.deltaTime;
            if (StartTime >= StartTimeEnd)
            {         
                Color_Arufa = 0.0f;
                TransperSpeed = 0.0f;
                Transparent = true;
            }
        }

        //スタートボタン押したら
        if (Input.GetKeyDown("joystick button 7") && StartSwitch == false)
        {
            //PressButtonの点滅スピード変える
            StartSwitch = true;
            TransperSpeed = TransperSpeed * 10;
        }

        //色の反映
        Color.a = Color_Arufa;
        spRenderer.color = Color;
    }
}
