using UnityEngine;
using UnityEngine.InputSystem;

public class BolaController : MonoBehaviour
{
    public float fuerza = 800f;
    private Rigidbody rb;
    private Vector2 inputMovimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue value)
    {
        inputMovimiento = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        Vector3 movimiento = new Vector3(inputMovimiento.x, 0, inputMovimiento.y) * fuerza * Time.fixedDeltaTime;
        rb.AddForce(movimiento);
    }
}