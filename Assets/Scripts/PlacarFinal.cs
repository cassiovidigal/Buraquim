using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlacarFinal : MonoBehaviour
{
    private float tempoFinal = 0;
    [SerializeField] private TMP_Text tempoFinalTexto;
    [SerializeField] private TMP_Text fase01;
    [SerializeField] private TMP_Text fase02;
    [SerializeField] private TMP_Text fase03;
    [SerializeField] private TMP_Text fase04;
    [SerializeField] private TMP_Text fase05;
    [SerializeField] private TMP_Text fase06;
    [SerializeField] private TMP_Text fase07;
    [SerializeField] private TMP_Text fase08;
    [SerializeField] private TMP_Text fase09;
    [SerializeField] private TMP_Text fase10;

    // Start is called before the first frame update
    void Start()
    {
        TempoFinal();
        PlacarFases();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TempoFinal()
    {
        for(int i = 0; i < 10; i++)
        {
            tempoFinal += PreloadManager.InstanciaPreloadManager.temposFases[i];
        }

        tempoFinalTexto.text = tempoFinal + "";
    }

    private void PlacarFases()
    {
        fase01.text = PreloadManager.InstanciaPreloadManager.temposFases[0] + "";
        fase02.text = PreloadManager.InstanciaPreloadManager.temposFases[1] + "";
        fase03.text = PreloadManager.InstanciaPreloadManager.temposFases[2] + "";
        fase04.text = PreloadManager.InstanciaPreloadManager.temposFases[3] + "";
        fase05.text = PreloadManager.InstanciaPreloadManager.temposFases[4] + "";
        fase06.text = PreloadManager.InstanciaPreloadManager.temposFases[5] + "";
        fase07.text = PreloadManager.InstanciaPreloadManager.temposFases[6] + "";
        fase08.text = PreloadManager.InstanciaPreloadManager.temposFases[7] + "";
        fase09.text = PreloadManager.InstanciaPreloadManager.temposFases[8] + "";
        fase10.text = PreloadManager.InstanciaPreloadManager.temposFases[9] + "";
    }
}
