using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_craft_charactor : MonoBehaviour
{
    public GameObject craft_inv;
    public GameObject charactor_inv;
    // Start is called before the first frame update

    public void switch_to_craft()
    {
        craft_inv.SetActive(true);
        charactor_inv.SetActive(false);
    }
    public void switch_to_charactor()
    {
        craft_inv.SetActive(false);
        charactor_inv.SetActive(true);
    }

    void Start()
    {
        switch_to_craft();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
