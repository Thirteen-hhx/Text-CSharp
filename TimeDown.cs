using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDown : MonoBehaviour
{
    
    public float CountDownTime;  //填写需要的时间，按秒计算，600秒就是10：00
    private float GameTime;
    private float timer = 0;
    public Text GameCountTimeText;

    void Start()
    {
        GameTime = CountDownTime;
    }

    void Update()
    {
        int M = (int)(GameTime / 60);
        float S = GameTime % 60;
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            timer = 0;
            GameTime--;
            GameCountTimeText.text = "逃离倒计时：" + M + "：" + string.Format("{0:00}", S);
        }
    }
}
