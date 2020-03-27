using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;

    private Vector2 startPosition;
    
    void Start()
    {
        launch();
    }

    private void launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1; //Direção aleatoria eixo x e y
        float y = Random.Range(0, 2) == 0 ? -1 : 1; //Direção aleatoria eixo x e y
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        launch();
    }
    public void increaseSpeed()
    {
        float velx = rb.velocity[0] + (rb.velocity[0] > 0 ? 1 : -1);   //Mantem direcao mas aumenta velocidade
        float vely = rb.velocity[1] + (rb.velocity[1] > 0 ? 1 : -1);   //Mantem direcao mas aumenta velocidade

        rb.velocity = new Vector2(velx, vely); //Update velocidade com base na velocidade inicial
    }
}
