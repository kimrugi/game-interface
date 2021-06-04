using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class harm_manager : MonoBehaviour
{
    fracture_manager frac;
    fire_manager fire;
    hunger_manager hunger;

    // Start is called before the first frame update
    void Start()
    {
        frac = GameObject.Find("fracture_manager").GetComponent<fracture_manager>();
        fire = GameObject.Find("fire_manager").GetComponent<fire_manager>();
        hunger = GameObject.Find("hunger_manager").GetComponent<hunger_manager>();

    }

   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            fire.active();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            frac.active();
        }
        
    }
}
