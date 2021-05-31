using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelup_button_manager : MonoBehaviour
{
    int[] stat_up_arr = new int[9];
    public Player player;
    public Text[] texts;
    public void health_up()
    {
        stat_up_arr[0] += 1;
    }
    public void stamina_up()
    {
        stat_up_arr[1] += 1;
    }
    public void oxygen_up()
    {
        stat_up_arr[2] += 1;
    }
    public void hunger_up()
    {
        stat_up_arr[3] += 1;
    }
    public void hydrogen_up()
    {
        stat_up_arr[4] += 1;
    }
    public void weight_up()
    {
        stat_up_arr[5] += 1;
    }
    public void power_up()
    {
        stat_up_arr[6] += 1;
    }
    public void speed_up()
    {
        stat_up_arr[7] += 1;
    }
    public void craft_up()
    {
        stat_up_arr[8] += 1;
    }
    public void apply()
    {
        player.stat_up(stat_up_arr);
        for(int i = 0; i < 9; ++i)
        {
            stat_up_arr[i] = 0;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 9; ++i)
        {
            if (texts[i])
                texts[i].text = string.Format("+{0}", stat_up_arr[i]);
        }
    }

    

}
