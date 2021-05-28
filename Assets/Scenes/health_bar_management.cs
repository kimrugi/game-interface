using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_bar_management : MonoBehaviour
{
    public Slider HealthBar;
    // Start is called before the first frame update
    
    public float hp;
    public float max_hp;
    void Start()
    {
        hp = 100;
        max_hp = 100;
    }
    // Update is called once per frame


    void Update()
    {
        if (HealthBar)
        {
            HealthBar.value = hp;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            hp -= 10;
            Debug.Log("zz");
        }
    }
    public void onClick()
    {
        hp -= 10;
    }
}
