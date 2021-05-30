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

    void deactive()
    {
        Image image = GameObject.Find("hunger_image").GetComponent<Image>();
        Color color = image.color;
        color.a = 0.0f;
        image.color = color;
        Text text = GameObject.Find("hunger_text").GetComponent<Text>();
        text.color = color;
        current_time = 0.0f;
        is_active = false;
    }
    public void active()
    {
        Image image = GameObject.Find("hunger_image").GetComponent<Image>();
        Color color = image.color;
        color.a = 1.0f;
        image.color = color;
        Text text = GameObject.Find("hunger_text").GetComponent<Text>();
        text.color = color;
        current_time = total_time;
        is_active = true;
    }

    void Start()
    {
        deactive();
        total_time = 3;
        current_time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_active)
        {
            current_time -= Time.deltaTime;
            if (current_time <= 0)
            {
                GameObject.Find("player").GetComponent<Player>().health -= 5;
                current_time = total_time;
            }
        }
    }
    
}
