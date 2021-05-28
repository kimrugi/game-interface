using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public int stamina;
    public int oxygen;
    public int hunger;
    public int hydrogen;
    public int weight;

    public int max_health;
    public int max_stamina;
    public int max_oxygen;
    public int max_hunger;
    public int max_hydrogen;
    public int max_weight;
    public int power;
    public int craft_skill;

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
        
    }
}
