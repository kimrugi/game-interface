using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory_manager : MonoBehaviour
{
    public GameObject inventory_canvas;
    bool inventory_on;
    public levelup_button_manager lbm;
    void Start()
    {
        inventory_on = false;
        inventory_canvas.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inventory_on)
            {
                inventory_on = false;
                inventory_canvas.SetActive(false);
                lbm.cancle();
            }
            else
            {
                inventory_on = true;
                inventory_canvas.SetActive(true);
            }
        }
    }
    /*
    bool inventory_on;

    public Transform inventory_parent;
    public Transform button_parent;
    [SerializeField] private Transform[] inventory_children;
    [SerializeField] private Transform[] button_children;

    Transform[] GetChildren(Transform parent)
    {
        Transform[] children = new Transform[parent.childCount];

        for (int i = 0; i < parent.childCount; i++)
        {
            children[i] = parent.GetChild(i);
        }
    
        return children;
    }

    void open_inventory()
    {
        Color color = fire_image.color;
        color.a = 1.0f;
        foreach (Transform child in inventory_children)
        {
            child.color = color;
        }
        foreach (Transform child in button_children)
        {
            child.interactable = true;
        }
        inventory_on = true;
    }

    void close_inventory()
    {
        Color color = fire_image.color;
        color.a = 0.0f;
        for (Transform child : inventory_children)
        {
            child.color = color;
        }
        for (Transform child : button_children)
        {
            child.interactable = false;
        }
        inventory_on = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        inventory_on = false;
        inventory_children = GetChildren(inventory_parent);
        button_children = GetChildren(button_parent);
        close_inventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inventory_on)
            {
                open_inventory();
            }
            else
            {
                close_inventory();
            }
        }
    }*/
}
