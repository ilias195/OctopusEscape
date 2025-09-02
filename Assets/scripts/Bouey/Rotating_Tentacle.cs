
using Unity.VisualScripting;
using UnityEngine;

public class Rotating_Tentacle : MonoBehaviour
{
    [SerializeField] private int rotationSpeed;
    [SerializeField] private int direction;
    void Start()
    {
        direction = Random.Range(1, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (direction > 50)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        if (this.transform.rotation.z > 10  && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("!!!");
        }
    }

    
}
