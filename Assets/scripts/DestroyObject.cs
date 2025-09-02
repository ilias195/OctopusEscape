using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
