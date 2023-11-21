using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    private TMP_Text texto;
    public bool isCounting;
    public float tempoContador = 0;

    private static Cronometro _instanciaCronometro;
    [SerializeField] public static GameObject instanciaCronometro;
    public static Cronometro InstanciaCronometro
    {
        get
        {
            if (_instanciaCronometro == null)
            {
                _instanciaCronometro = instanciaCronometro.GetComponent<Cronometro>();
            }
            return _instanciaCronometro;
        }
    }

    private void Awake()
    {
        instanciaCronometro = FindObjectOfType<Cronometro>().gameObject;
        DontDestroyOnLoad(instanciaCronometro);
    }
    // Start is called before the first frame update
    void Start()
    {
        tempoContador = 0;
        texto = GetComponent<TMP_Text>();
        texto.text = "";
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        ContarCronometro();
        AtualizarInterfaceContador();
    }

    private void ContarCronometro()
    {
        if (isCounting)
        {
            tempoContador += Time.deltaTime;
        }
    }

    private void AtualizarInterfaceContador()
    {
        if (isCounting)
        {
            texto.text = "Tempo: "+String.Format("{0:0.0}", tempoContador);
        }
    }

    public void PausarCronometro()
    {
        isCounting = false;
    }

    public float TempoFinal()
    {
        return tempoContador;
    }


}
