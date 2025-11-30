using UnityEngine;

public class RotarPlataforma : MonoBehaviour
{
    public float velocidad = 120f;

    void Update()
    {
        float direccion = 0f;

        // Mouse (para pruebas en PC)
        if (Input.GetMouseButton(0))
        {
            direccion = Input.mousePosition.x > Screen.width / 2f ? 1f : -1f;
        }

        // Touch (para móvil) – funciona aunque tengas el nuevo Input System
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                direccion = touch.position.x > Screen.width / 2f ? 1f : -1f;
            }
        }

        if (direccion != 0f)
        {
            transform.Rotate(0f, direccion * velocidad * Time.deltaTime, 0f);
        }
    }
}