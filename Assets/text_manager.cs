using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class text_manager : MonoBehaviour
{
    public float TIMER = 50;
    public float text_timer;
    public Text alarm_text;
    public bool is_alarm;
    // Start is called before the first frame update
    void Start()
    {
        alarm_text.text = "";
        text_timer = TIMER;
        is_alarm = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_alarm)
        {
            text_timer -= Time.deltaTime;
            if(text_timer <= 0)
            {
                alarm_text.text = "";
                text_timer = TIMER;
                is_alarm = false;
            }
        }
        if (Input.GetKey(KeyCode.Z))
        {
            alarm_text.text = "레벨 업했습니다.";
            is_alarm = true;
        }
    }
}
