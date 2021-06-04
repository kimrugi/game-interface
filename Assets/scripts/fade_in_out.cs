using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade_in_out : MonoBehaviour
{
    public float fade_time;
    public Image[] image;
    bool is_in;
    bool is_out;
    bool is_stopped;
    float currentTime;
    float percent;
    // Start is called before the first frame update
    void Start()
    {
        is_in = false;
        is_out = false;
        is_stopped = true;
        currentTime = 0.0f;
        percent = 0.0f;
        for (int i = 0; i < image.Length; ++i)
        {
            Color color = image[i].color;
            color.a = 0;
            image[i].color = color;
        }
    }
    void Update()
    {
        if (!is_stopped)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fade_time;
            if (is_in)
            {
                for (int i = 0; i < image.Length; ++i)
                {
                    Color color = image[i].color;
                    color.a = percent;
                    image[i].color = color;
                }
            }
            else if (is_out)
            {
                for (int i = 0; i < image.Length; ++i)
                {
                    Color color = image[i].color;
                    color.a = 1 - percent;
                    image[i].color = color;
                }
            }
            if (percent >= 1)
            {
                is_stopped = true;
                is_in = false;
                is_out = false;
            }
        }
    }
    public void fade_in()
    {
        is_in = true;
        is_stopped = false;
        currentTime = 0.0f;
        percent = 0.0f;
    }
    public void fade_out()
    {
        is_out = true;
        is_stopped = false;
        currentTime = 0.0f;
        percent = 0.0f;
    }
    
}
