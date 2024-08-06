using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform target; // El objeto que la c�mara seguir�
    public float distance = 5f; // Distancia entre la c�mara y el objetivo
    public float height = 2f; // Altura de la c�mara sobre el objetivo
    public float rotationSpeed = 3f; // Velocidad de rotaci�n de la c�mara

    private float currentRotationX = 0f;

    private void LateUpdate()
    {
        // Calcula la rotaci�n de la c�mara con el mouse
        float mouseX = Input.GetAxis("Mouse X");
        currentRotationX += mouseX * rotationSpeed;
        currentRotationX = Mathf.Clamp(currentRotationX, -90f, 90f); // Limita la rotaci�n vertical

        // Calcula la posici�n de la c�mara
        Quaternion rotation = Quaternion.Euler(0f, currentRotationX, 0f);
        Vector3 desiredPosition = target.position - rotation * Vector3.forward * distance + Vector3.up * height;
        transform.position = desiredPosition;

        // Mira hacia el objetivo
        transform.LookAt(target);
    }
}
