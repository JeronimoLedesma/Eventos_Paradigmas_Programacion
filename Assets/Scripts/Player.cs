using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5;
    public float health;
    public delegate void HealthEvent(float lp);
    public static HealthEvent healthEvent;
    [SerializeField] private float radio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Caminar();
        if (Input.GetKeyDown(KeyCode.J))
        {
            RecibirDaño();
        }
        /*if (Input.GetKeyDown(KeyCode.K))
        {
            Collider2D collider = Physics2D.OverlapCircle(transform.position, radio);
            if (collider.GetComponent<NPC>() != null)
            {
                collider.GetComponent<NPC>().Talk();
            }
        }*/
    }

    void Caminar()
    {
        var movimiento = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(movimiento * speed, 0);
    }
    
    void RecibirDaño()
    {
        healthEvent?.Invoke(10);
    }
}
