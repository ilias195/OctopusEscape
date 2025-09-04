using UnityEngine;


public class checker : MonoBehaviour
{
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button3;
    [SerializeField] private GameObject button4;
    [SerializeField] private GameObject button5;
    [SerializeField] private GameObject button6;
    [SerializeField] private GameObject button7;
    [SerializeField] private GameObject button8;
    [SerializeField] private GameObject button9;

    [SerializeField] private GameObject closedDoor;
    [SerializeField] private GameObject openDoor;

    SpriteRenderer spriteRenderer;

    private bool state = false;
    public bool switch1 = false;
    public bool switch2 = false;
    public bool switch3 = false;
    public bool switch4 = false;
    public bool switch5 = false;
    public bool switch6 = false;
    public bool switch7 = false;
    public bool switch8 = false;
    public bool switch9 = false;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;

        closedDoor.SetActive(true);
        openDoor.SetActive(false);
    }

    void Update()
    {
        if (switch1 && switch2 && switch3 && switch4 && switch5 && switch6 && switch7 && switch8 && switch9 || Input.GetKeyDown(KeyCode.R))
        {
            state = true;

            closedDoor.SetActive(false );
            openDoor.SetActive(true);
        }

        if (state)
        {
            spriteRenderer.color = Color.green;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            switch1 = !switch1;
            switch2 = !switch2;
            switch4 = !switch4;
            Debug.Log("Flipped switch 1");
            
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            switch2 = !switch2;
            switch1 = !switch1;
            switch5 = !switch5;
            switch3 = !switch3;
            Debug.Log("Flipped switch 2");
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            switch3 = !switch3;
            switch6 = !switch6;
            switch2 = !switch2;
            Debug.Log("Flipped switch 3");
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            switch4 = !switch4;
            switch7 = !switch7;
            switch1 = !switch1;
            switch5 = !switch5;
            Debug.Log("Flipped switch 4");
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            switch5 = !switch5;
            switch4 = !switch4;
            switch2 = !switch2;
            switch8 = !switch8;
            switch6 = !switch6;
            Debug.Log("Flipped switch 5");
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            switch6 = !switch6;
            switch9 = !switch9;
            switch5 = !switch5;
            switch3 = !switch3;
            Debug.Log("Flipped switch 6");
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            switch7 = !switch7;
            switch4 = !switch4;
            switch8 = !switch8;
            Debug.Log("Flipped switch 7");
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            switch8 = !switch8;
            switch7 = !switch7;
            switch5 = !switch5;
            switch9 = !switch9;
            Debug.Log("Flipped switch 8");
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            switch9 = !switch9;
            switch8 = !switch8;
            switch6 = !switch6;
            Debug.Log("Flipped switch 9");
        }
    }
}
