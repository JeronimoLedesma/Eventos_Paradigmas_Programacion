using UnityEngine;

public class Item : MonoBehaviour
{
    public delegate void ItemEvent(string item);
    public static ItemEvent OnCollected;
    [SerializeField] string nombre;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<Player>() != null)
        {
            OnCollected?.Invoke(nombre);
            Destroy(this.gameObject);
        }
    }
}
