using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class health_bar_management : MonoBehaviour
{
    public Slider health_bar;
    public Slider stamina_bar;
    // Start is called before the first frame update
    public Image weight;
    public Image hunger;
    public Image o2;
    public Image hydro;

    public Image O2_UI;

    public Player player;

    Color full_color;

    void color_change(Image image)
    {
        Color color_alpha = image.color;
        Color color = Color.Lerp(Color.red, full_color, image.fillAmount);
        color.a = color_alpha.a;
        image.color = color;
    }

    void Start()
    {
        full_color = hunger.color;
    }
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
        if (player)
        {
            
            if (weight)
            {
                weight.fillAmount = player.weight / player.max_weight;
                color_change(weight);
            }
            if (hunger)
            {
                hunger.fillAmount = player.hunger / player.max_hunger;
                color_change(hunger);
            }
            if (o2)
            {
                o2.fillAmount = player.oxygen / player.max_oxygen;
                color_change(o2);
            }

            if (hydro)
            {
                hydro.fillAmount = player.hydrogen / player.max_hydrogen;
                color_change(hydro);
            }

        }
        
    }
}
