using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AcelerometroInvertido : MonoBehaviour
{
    [SerializeField] private TMP_Text inputX;
    [SerializeField] private TMP_Text inputY;
    private Rigidbody2D rb;
    private float dirX;
    private float dirY;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float deadZone;
    private bool faseEncerrada = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CorrecaoDeadZone(Input.acceleration.x) * moveSpeed;
        dirY = CorrecaoDeadZone(Input.acceleration.y) * moveSpeed;

        //transform.position = 
        AtualizarInput();
    }

    private void FixedUpdate()
    {
        MovimentacaoBolinha();
    }

    private void AtualizarInput()
    {
        inputX.text = "X: " + dirX;
        inputY.text = "Y: " + dirY;
    }

    private float CorrecaoDeadZone(float valor)
    {
        int sinal = 1;
        if(valor < 0) {
            sinal = -1;
        }

        float valorFinal = Mathf.Abs(valor);
        if(valorFinal < deadZone){
            valorFinal = 0;
        }

        return valorFinal * sinal;

    }

    private void MovimentacaoBolinha()
    {
        if (!faseEncerrada)
        {
            rb.velocity = new Vector2(dirX, dirY);
        }
    }

    public void PararBolinha()
    {
        faseEncerrada = true;
    }
}
