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
    void deactive()
    {
        Image image = GameObject.Find("fracture_image").GetComponent<Image>();
        Color color = image.color;
        color.a = 0.0f;
        image.color = color;
        Text text = GameObject.Find("fracture_text").GetComponent<Text>();
        text.color = color;
        gage.fillAmount = 0.0f;
        current_time = 0.0f;
        is_active = false;
    }
    public void active()
    {
        Image image = GameObject.Find("fracture_image").GetComponent<Image>();
        Color color = image.color;
        color.a = 1.0f;
        image.color = color;
        Text text = GameObject.Find("fracture_text").GetComponent<Text>();
        text.color = color;
        current_time = 10.0f;
        is_active = true;
    }

    void Start()
    {
        gage = GameObject.Find("fracture").GetComponent<Image>();
        deactive();
        total_time = 10;
        current_time = 0;
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
