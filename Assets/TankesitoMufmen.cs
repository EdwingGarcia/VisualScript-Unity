using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankesitoMufmen : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del tanque (ajusta seg�n sea necesario)
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // Verificar si alguna tecla de movimiento est� presionada
        bool isMoving = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) ||
                        Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) ||
                        Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) ||
                        Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);


        // Si alguna tecla de movimiento est� presionada, aplicar movimiento hacia adelante
        if (isMoving)
        {
            // Obtener la direcci�n hacia adelante del tanque (basada en su rotaci�n actual)
            Vector3 moveDirection = transform.forward;


            // Aplicar movimiento hacia adelante en la direcci�n actual del tanque
            rb.velocity = moveDirection * moveSpeed;
        }
        else
        {
            // Si no se presiona ninguna tecla de movimiento, detener el movimiento
            rb.velocity = Vector3.zero;
        }
    }


    void Update()
    {
        // Rotar el tanque seg�n la tecla presionada
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            // Rotar hacia arriba (0 grados)
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            // Rotar hacia la derecha (90 grados)
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            // Rotar hacia la izquierda (-90 grados)
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            // Rotar hacia abajo (180 grados)
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }
}