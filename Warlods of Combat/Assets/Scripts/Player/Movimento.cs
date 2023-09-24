using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidadeMovimento;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(movimentoHorizontal, 0.0f, movimentoVertical);

        // Normalizar o movimento para que o personagem não se mova mais rápido na diagonal
        movimento.Normalize();

        transform.Translate(movimento * velocidadeMovimento * Time.deltaTime)
    }
}
