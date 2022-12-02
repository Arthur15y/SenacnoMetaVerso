using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    public CharacterController oCharacterController;
    public float velocidadeDoJogador;
    public float alturaDoPuloDoJogador;
    public float gravidadeDoJogador;
    public Transform verificadorDeChao;
    public float alcanceDoVerificador;
    public LayerMask layerDoChao;
    private Vector3 velocidadeDeQueda;
    private bool estaNoChao;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      MoverJogador(); 
      AplicarGravidade(); 
    }

    private void MoverJogador()
    {
        float movimentoX = Input.GetAxis("Horizontal");
        float movimentoZ = Input.GetAxis("Vertical");

        Vector3 movimentoFinal = transform.right * movimentoX + transform.forward * movimentoZ;


        oCharacterController.Move(movimentoFinal * velocidadeDoJogador * Time.deltaTime);
    }
    private void AplicarGravidade()
    {
      estaNoChao = Physics.CheckSphere(verificadorDeChao.position, alcanceDoVerificador, layerDoChao);
      Debug.Log(estaNoChao);
    }
}
