using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform target; // El objeto que la cámara seguirá
    public float distance = 5f; // Distancia entre la cámara y el objetivo
    public float height = 2f; // Altura de la cámara sobre el objetivo
    public float rotationSpeed = 3f; // Velocidad de rotación de la cámara

    private float currentRotationX = 0f;

    private void LateUpdate()
    {
        // Calcula la rotación de la cámara con el mouse
        float mouseX = Input.GetAxis("Mouse X");
        currentRotationX += mouseX * rotationSpeed;
        currentRotationX = Mathf.Clamp(currentRotationX, -90f, 90f); // Limita la rotación vertical

        // Calcula la posición de la cámara
        Quaternion rotation = Quaternion.Euler(0f, currentRotationX, 0f);
        Vector3 desiredPosition = target.position - rotation * Vector3.forward * distance + Vector3.up * height;
        transform.position = desiredPosition;

        // Mira hacia el objetivo
        transform.LookAt(target);
    }
}
