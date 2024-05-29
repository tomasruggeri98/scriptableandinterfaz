using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador

    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtener el componente Rigidbody2D del jugador
    }

    void Update()
    {
        // Obtener la entrada de los ejes horizontal y vertical (izquierda/derecha y arriba/abajo)
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        moveInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // Aplicar el movimiento al Rigidbody
        rb.velocity = moveInput * speed;
    }
}
