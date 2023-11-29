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
    [SerializeField] private Button botaoVoltar;

    // Start is called before the first frame update
    void Start()
    {
        IniciarListenersBotoes();
        TempoFinal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TempoFinal()
    {
        int id = PreloadManager.InstanciaPreloadManager.GetUltimoLabirinto();
        tempoFinal += PreloadManager.InstanciaPreloadManager.temposFases[id];

        tempoFinalTexto.text = tempoFinal + "";
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
