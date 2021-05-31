using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class status_manager : MonoBehaviour
{
    public Slider health_bar;
    public Slider stamina_bar;
    public Slider oxygen;
    public Slider hunger;
    public Slider hydrogen;
    public Slider weight;
    public Slider power;
    public Slider speed;
    public Slider craft;

    public Text health_text;
    public Text stamina_text;
    public Text oxygen_text;
    public Text hunger_text;
    public Text hydrogen_text;
    public Text weight_text;
    public Text power_text;
    public Text speed_text;
    public Text craft_text;

    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        power.value = 1.0f;
        speed.value = 1.0f;
        craft.value = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (health_bar)
        {
            health_bar.value = player.health / player.max_health;
        }
        if (stamina_bar)
        {
            stamina_bar.value = player.stamina / player.max_stamina;
        }
        if (oxygen)
        {
            oxygen.value = player.oxygen / player.max_oxygen;
        }
        if (hunger)
        {
            hunger.value = player.hunger / player.max_hunger;
        }
        if (hydrogen)
        {
            hydrogen.value = player.hydrogen / player.max_hydrogen;
        }
        if (weight)
        {
            weight.value = player.weight / player.max_weight;
        }
        if (health_text)
        {
            health_text.text = string.Format("{0:0}/{1}", player.health, player.max_health);
        }
        if (stamina_text)
            stamina_text.text = string.Format("{0:0}/{1}", player.stamina, player.max_stamina);
        if (oxygen_text)
            oxygen_text.text = string.Format("{0:0}/{1}", player.oxygen, player.max_oxygen);
        if (hunger_text)
            hunger_text.text = string.Format("{0:0}/{1}", player.hunger, player.max_hunger);
        if (hydrogen_text)
            hydrogen_text.text = string.Format("{0:0}/{1}", player.hydrogen, player.max_hydrogen);
        if (weight_text)
            weight_text.text = string.Format("{0:0}/{1}", player.weight, player.max_weight);
        if (power_text)
            power_text.text = player.power.ToString();
        if (speed_text)
            speed_text.text = player.speed.ToString();
        if (craft_text)
            craft_text.text = player.craft_skill.ToString();

        /*stamina_text;
        oxygen_text;
        hunger_text;
        hydrogen_text;
        weight_text;
        power_text;
        speed_text;
        craft_text;*/
    }
}
