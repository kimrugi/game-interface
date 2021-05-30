using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fire_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool is_active;
    Image fire_gage;
    public float fire_time;
    public float current_time;
    void deavtive()
    {
        Image fire_image = GameObject.Find("fire_image").GetComponent<Image>();
        Color color = fire_image.color;
        color.a = 0.0f;
        fire_image.color = color;
        Text text = GameObject.Find("fire_text").GetComponent<Text>();
        text.color = color;
        fire_gage.fillAmount = 0.0f;
        current_time = 0.0f;
        is_active = false;
    }
    public void active()
    {
        Image fire_image = GameObject.Find("fire_image").GetComponent<Image>();
        Color color = fire_image.color;
        color.a = 1.0f;
        fire_image.color = color;
        Text text = GameObject.Find("fire_text").GetComponent<Text>();
        text.color = color;
        fire_gage.fillAmount = 1.0f;
        current_time = 10;
        is_active = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        fire_gage = GameObject.Find("fire").GetComponent<Image>();
        deavtive();
        fire_time = 10;
        current_time = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (is_active)
        {
            current_time -= Time.deltaTime;
            GameObject.Find("player").GetComponent<Player>().get_damage(Time.deltaTime * 5.0f);
            fire_gage.fillAmount = (float)current_time / fire_time;
            if (current_time <= 0)
            {
                deavtive();
            }
        }
    }
    
}

