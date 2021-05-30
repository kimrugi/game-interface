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
    public float craft_skill;

    void reduce_hunger(float red)
    {
        hunger -= red;
    }
    void reduce_hydrogen(float red)
    {
        hydrogen -= red;
    }
    public void get_damage(float amount)
    {
        health -= amount;
    }
    // Start is called before the first frame update
    void Start()
    {
        health = stamina = oxygen = hunger = hydrogen = 100;
        max_health = max_stamina = max_oxygen = max_hunger = max_hydrogen = max_weight =
            power = craft_skill = 100;
        weight = 0;
}

    // Update is called once per frame
    void Update()
    {
        reduce_hunger(Time.deltaTime * 0.1f);
        reduce_hydrogen(Time.deltaTime * 0.1f);
    }
}
