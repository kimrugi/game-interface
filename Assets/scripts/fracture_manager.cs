using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fracture_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool is_active;
    Image gage;
    public float total_time;
    public float current_time;
    // Start is called before the first frame update
    public Text text;
    public fade_in_out fade;

    public void show_text()
    {
        if (is_active)
        {
            Color color = text.color;
            color.a = 1.0f;
            text.color = color;
        }
    }

    public void hide_text()
    {
        Color color = text.color;
        color.a = 0.0f;
        text.color = color;
    }
    void deactive()
    {
        fade.fade_out();
        
        gage.fillAmount = 0.0f;
        current_time = 0.0f;
        is_active = false;
    }
    public void active()
    {
        if (!is_active)
        {
            fade.fade_in();
        }

        current_time = 10.0f;
        is_active = true;
    }

    void Start()
    {
        gage = GameObject.Find("fracture").GetComponent<Image>();
        deactive();
        total_time = 10;
        current_time = 0;
        hide_text();
    }

    // Update is called once per frame
    void Update()
    {

        if (is_active)
        {
            current_time -= Time.deltaTime;
            //GameObject.Find("player").GetComponent<Player>().health -= Time.deltaTime * 5;
            gage.fillAmount = (float)current_time / total_time;
            if (current_time <= 0)
            {
                deactive();
            }
        }
    }
    
}
