using NUnit.Framework;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class object_checker : MonoBehaviour
{
    [SerializeField] private GameObject Item;
    [SerializeField] private GameObject closedSprite1;
    [SerializeField] private GameObject closedSprite2;
    [SerializeField] private GameObject openSprite;
    public mouse_hover mouse_Hover;
    private bool active = false;
    private void Start()
    {
        openSprite.SetActive(false);
    }
    void Update()
    {
        if (Item != null)
        {
            active = false;
        }
        else
        {
            active = true;
        }

        if (closedSprite1 == null) 
        {
            Destroy(mouse_Hover);
        }
    }

    private void OnMouseUp()
    {
        if (active)
        {
            closedSprite1.SetActive(false);
            closedSprite2.SetActive(false);
            openSprite.SetActive(true);
            Destroy(closedSprite2);
            Destroy(closedSprite1);
        }
    }
}
