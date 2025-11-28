using UnityEngine;

public class CamaraSeguir : MonoBehaviour
{
    public Transform objetivo;        // BolaJugador
    public Vector3 offset = new Vector3(0, 7, -10);
    public float suavidad = 0.125f;

    void LateUpdate()
    {
        if (objetivo != null)
        {
            Vector3 posicionDeseada = objetivo.position + offset;
            posicionDeseada.y = offset.y; // ← Y siempre fija
            Vector3 posicionSuave = Vector3.Lerp(transform.position, posicionDeseada, suavidad);
            transform.position = posicionSuave;
        }
    }
}