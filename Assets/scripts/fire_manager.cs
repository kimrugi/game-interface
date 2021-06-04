using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fire_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool is_active;
    Image fire_gage;
    float fire_time;
    float current_time;
    float damage_term;
    float damage_time;
    float fire_damage;
    public Text text;

    void deavtive()
    {
        Image fire_image = GameObject.Find("fire_image").GetComponent<Image>();
        Color color = fire_image.color;
        color.a = 0.0f;
        fire_image.color = color;
        
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
        
        
        fire_gage.fillAmount = 1.0f;
        current_time = 10;
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

    // Start is called before the first frame update
    void Start()
    {
        fire_gage = GameObject.Find("fire").GetComponent<Image>();
        deavtive();
        fire_time = 10;
        current_time = 0;
        damage_term = 1;
        damage_time = 0;
        fire_damage = 5;
        hide_text();
    }

    // Update is called once per frame
    void Update()
    {

        if (is_active)
        {
            current_time -= Time.deltaTime;
            damage_time += Time.deltaTime;
            if (damage_time >= damage_term)
            {
                GameObject.Find("player").GetComponent<Player>().get_damage(damage_term * fire_damage);
                damage_time = damage_time % damage_term;
            }
            
            fire_gage.fillAmount = (float)current_time / fire_time;
            if (current_time <= 0)
            {
                deavtive();
            }
        }
    }
    
}

