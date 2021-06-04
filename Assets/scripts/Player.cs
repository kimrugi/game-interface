using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;
    public float stamina;
    public float oxygen;
    public float hunger;
    public float hydrogen;
    public float weight;

    public float max_health;
    public float max_stamina;
    public float max_oxygen;
    public float max_hunger;
    public float max_hydrogen;
    public float max_weight;
    public float power;
    public float speed;
    public float craft_skill;

    float damage_amount;
    float damaged_time;
    float damage_time_rate;

    bool is_drowning;

    public hunger_manager hm;
    public fade_in_out fin;

    void in_out_water()
    {
        if (is_drowning)
            is_drowning = false;
        else
        {
            is_drowning = true;
            fin.fade_in();
        }
    }

    void reduce_hunger(float red)
    {
        hunger -= red;
        if (hunger < max_hunger / 7) {
            hm.active();
        }
    }
    void eat_food()
    {
        hunger += 10;
        if (hunger > max_hunger / 7)
        {
            hm.deactive();
        }
    }
    void reduce_hydrogen(float red)
    {
        hydrogen -= red;
    }
    public void get_damage(float amount)
    {
        damage_amount =+ amount;
        damaged_time = 0.1f;
        damage_time_rate = damage_amount / damaged_time;
    }
    public void stat_up(int[] arr)
    {
        max_health += arr[0] * 10;
        max_stamina += arr[1] * 10;
        max_oxygen += arr[2] * 10;
        max_hunger += arr[3] * 10;
        max_hydrogen += arr[4] * 10;
        max_weight += arr[5] * 10;
        power += arr[6] * 10;
        speed += arr[7] * 10;
        craft_skill += arr[8] * 10;

    }
    // Start is called before the first frame update
    void Start()
    {
        health = stamina = oxygen = hunger = hydrogen = 100;
        max_health = max_stamina = max_oxygen = max_hunger = max_hydrogen = max_weight =
            power = craft_skill =  speed = 100;
        weight = 0;
        damaged_time = 0;
        damage_amount = 0;
        is_drowning = false;
}

    // Update is called once per frame
    void Update()
    {
        reduce_hunger(Time.deltaTime * 0.1f);
        reduce_hydrogen(Time.deltaTime * 0.1f);
        if (damaged_time > 0)
        {
            damaged_time -= Time.deltaTime;
            health -= damage_time_rate * Time.deltaTime;
            damage_amount -= damage_time_rate * Time.deltaTime;
            if(damaged_time <= 0)
            {
                damaged_time = 0;
                health -= damage_amount;
                damage_amount = 0;
            }
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("quit");
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            in_out_water();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            reduce_hunger(10);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            eat_food();
        }
        if (is_drowning)
        {
            oxygen -= 20 * Time.deltaTime;
        }
        else if (oxygen < max_oxygen)
        {
            oxygen += 20 * Time.deltaTime;
            if (oxygen >= max_oxygen)
            {
                oxygen = max_oxygen;
                fin.fade_out();
            }
        }
    }
}
