using UnityEngine;

using UnityEngine.SceneManagement;

public class door2 : MonoBehaviour
{
    private float timer = 0;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            SceneManager.LoadScene(2);
        }
    }
}

