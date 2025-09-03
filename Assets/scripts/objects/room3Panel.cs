using System;
using UnityEngine;

public class room3Panel : MonoBehaviour
{
    [SerializeField] private GameObject puzzlescreen;

    private bool state;
    [SerializeField] private GameObject sprite1;
    [SerializeField] private GameObject sprite2;
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            puzzlescreen.SetActive(false);
        }

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

    private void OnMouseUp()
    {
        puzzlescreen.SetActive(true);
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
