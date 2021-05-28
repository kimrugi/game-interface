using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manage : MonoBehaviour
{
    GameObject hpGage;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGage = GameObject.Find("fire");
    }

    public void DecreaseHP()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
