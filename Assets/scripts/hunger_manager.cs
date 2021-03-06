using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hunger_manager : MonoBehaviour
{
    public bool is_active;
    public float total_time;
    public float current_time;
    // Start is called before the first frame update
    public Text text;
    public fade_in_out fade;

    public void deactive()
    {
        
        fade.fade_out();
        

        current_time = 0.0f;
        is_active = false;
    }
    public void active()
    {
        if (!is_active)
        {
            fade.fade_in();
        }

        current_time = total_time;
        is_active = true;
    }
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

    void Start()
    {
        deactive();
        total_time = 3;
        current_time = 0;
        hide_text();
    }

    // Update is called once per frame
    void Update()
    {
        if (is_active)
        {
            current_time -= Time.deltaTime;
            if (current_time <= 0)
            {
                GameObject.Find("player").GetComponent<Player>().get_damage(5);
                current_time = total_time;
            }
        }
    }
    
}
