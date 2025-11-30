using UnityEngine;

public class BolaController : MonoBehaviour
{
    public float fuerzaSalto = 150f;
    private Rigidbody rb;
    private bool puedeSaltar = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Salta al tocar/clear la pantalla (móvil o PC)
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            if (puedeSaltar)
            {
                rb.AddForce(Vector3.up * fuerzaSalto);
                puedeSaltar = false;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Plataforma"))
        {
            puedeSaltar = true;
            GameManager.Instance.SumarPunto(); // +1 punto
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Plataforma"))
        {
            puedeSaltar = false;
        }
    }
}