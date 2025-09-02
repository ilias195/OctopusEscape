using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class object_checker : MonoBehaviour
{
    [SerializeField] private GameObject Item;
    private bool active = false;

    SpriteRenderer spriteRenderer;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        if (Item != null)
        {
            spriteRenderer.color = Color.red;
        }
        else
        {
            spriteRenderer.color = Color.green;
            active = true;
        }
    }

    private void OnMouseUp()
    {
        if (active)
        {
            SceneManager.LoadScene(0);
        }
    }
}
