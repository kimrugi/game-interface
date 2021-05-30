using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weight_status : MonoBehaviour
{
    Image gage;
    // Start is called before the first frame update
    void Start()
    {
        gage = GameObject.Find("weight_bar").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        gage.fillAmount = GameObject.Find("player").GetComponent<Player>().weight /
            GameObject.Find("player").GetComponent<Player>().max_weight;
    }
}
