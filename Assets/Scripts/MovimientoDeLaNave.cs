using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoDeLaNave : MonoBehaviour
{
    private Vector2 movimiento;
    private Rigidbody2D rb;
    private Inputs input;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        input = new Inputs();
        input.Nave.Movimiento.Enable();
        input.Nave.Movimiento.performed += OnMovimiento;

    }

    private void OnMovimiento( InputAction.CallbackContext value)
    {
        movimiento = value.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * Time.fixedDeltaTime);
    }
}
