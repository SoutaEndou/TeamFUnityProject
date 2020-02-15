using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManagerScript : MonoBehaviour
{
    //ボタン押してからこの秒数経過でシーン遷移
    public float ToGameStage = 2.0f;

    private bool OnStart = false;
    public float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //スタートボタンを押す
        if (Input.GetKeyDown("joystick button 7"))
        {
            OnStart = true;
        }

        //一定時間経過でシーン遷移
        if (OnStart == true)
        {
            time += Time.deltaTime;

            if (time >= ToGameStage)
            {
                SceneManager.LoadScene("GameStage");
            }
        }
    }
}
