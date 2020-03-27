using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;

    private Vector3 startPosition;

    private float movement;

    void Start()
    {
        startPosition = transform.position;   
    }

    void Update()
    {
        movement = Input.GetAxisRaw("Vertical");    //W e S são default ... Retorna como valores -1 ... 1
        rb.velocity = new Vector2(rb.velocity.x, movement * speed); //Velocidade do paddle
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero; //Reseta velocidade
        transform.position = startPosition; //Reseta posição
    }
}
