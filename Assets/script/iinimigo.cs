using System.Collections;

using System.Collections.Generic;

using UnityEngine;

 

public class iinimigo : MonoBehaviour

{

    public float velocidade = 2.0f;

    public float distancia = 2.0f;

    private bool moveParaDireita = true;

    private Vector3 posicaoInicial;

    private SpriteRenderer spriteRenderer;

 

    void Start()

    {

        posicaoInicial = transform.position;

        spriteRenderer = GetComponent<SpriteRenderer>();

    }

 

    void Update()

    {

        if (moveParaDireita)

        {

            transform.Translate(Vector2.right * velocidade * Time.deltaTime);

            spriteRenderer.flipX = false;

        }

        else

        {

            transform.Translate(Vector2.left * velocidade * Time.deltaTime);

            spriteRenderer.flipX = true;

        }

 

        if (Mathf.Abs(transform.position.x - posicaoInicial.x) >= distancia)

        {

            moveParaDireita = !moveParaDireita;

        }

    }
}
