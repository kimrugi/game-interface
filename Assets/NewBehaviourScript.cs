using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject hpGage;
    public float fire_time;
    public float current_time;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGage = GameObject.Find("fire");
        fire_time = 10;
        current_time = 10;
    }

    // Update is called once per frame
    void Update()
    {
        this.hpGage.GetComponent<Image>().fillAmount = (float)current_time / fire_time;
        current_time -= Time.deltaTime;
    }
}
