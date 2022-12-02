using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionarcamera : MonoBehaviour
{

    public Transform corpoDoJogador;
    public float sensibilidadeDoMouse;
    private float rotacaoX;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  
    }

    // Update is called once per frame
    void Update()
    {
     RotacionarJogador();   
    }

    private void RotacionarJogador()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensibilidadeDoMouse * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensibilidadeDoMouse * Time.deltaTime;

        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);
        corpoDoJogador.Rotate(Vector3.up * mouseX);
    }
}
