using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlacarFinalLabirinto : MonoBehaviour
{
    private float tempoFinal = 0;
    [SerializeField] private TMP_Text tempoFinalTexto;
    [SerializeField] private TMP_Text fase01;
    [SerializeField] private TMP_Text fase02;
    [SerializeField] private TMP_Text fase03;
    [SerializeField] private Button botaoVoltar;

    // Start is called before the first frame update
    void Start()
    {
        IniciarListenersBotoes();
        TempoFinal();
        PlacarFases();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TempoFinal()
    {
        for(int i = 10; i < 13; i++)
        {
            tempoFinal += PreloadManager.InstanciaPreloadManager.temposFases[i];
        }

        tempoFinalTexto.text = tempoFinal + "";
    }

    private void PlacarFases()
    {
        fase01.text = PreloadManager.InstanciaPreloadManager.temposFases[10] + "";
        fase02.text = PreloadManager.InstanciaPreloadManager.temposFases[11] + "";
        fase03.text = PreloadManager.InstanciaPreloadManager.temposFases[12] + "";
    }

    public void VoltarMenuPrincipal()
    {
        SceneManager.LoadScene("Scenes/Fase0", LoadSceneMode.Single);
    }

    private void OnButtonVoltarClick()
    {
        VoltarMenuPrincipal();
    }

    private void IniciarListenersBotoes()
    {
        botaoVoltar.onClick.AddListener(OnButtonVoltarClick);
    }
}
