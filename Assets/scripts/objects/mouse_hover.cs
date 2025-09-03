using System;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class mouse_hover : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    private bool state;
    [SerializeField] private GameObject sprite1;
    [SerializeField] private GameObject sprite2;

    void Update()
    {
        

        if (state)
        {
            sprite1.SetActive(true);
            //sprite2.SetActive(false);
            Console.WriteLine("Enter");
        }
        else
        {
            sprite1.SetActive(false);
            //sprite2.SetActive(true);
            Console.WriteLine("exit");
        }

        if (sprite1 == null || sprite2 == null) 
        {
            Destroy(this);
        }
    }

    private void OnMouseEnter()
    {
        state = !state;
    }

    private void OnMouseExit()
    {
        state = !state;
    }
}
