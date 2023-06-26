using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Variavel para controlar a velocidade do objeto BF
    public float velocidade = 1.0f;
    // Variavel para controle do ponto de reposicao
    public float reposicao = 18 ;
    // Variavel para guardar a posicao inicial do objeto
    public Vector3 posicaoInicial;

   
    void Start()
    {
       posicaoInicial = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
       float novoPosicao = Mathf.Repeat(Time.time * velocidade,reposicao);
       transform.position = posicaoInicial + Vector3.down * novoPosicao;
    }
}
