using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Movimiento con WASD
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcula la dirección del movimiento
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement.Normalize(); // Normaliza para evitar movimientos más rápidos en diagonal

        // Aplica el movimiento
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
