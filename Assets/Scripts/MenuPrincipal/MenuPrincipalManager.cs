using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private Button botaoJogar;
    [SerializeField] private Button botaoCreditos;
    [SerializeField] private Button botaoLabirintos;
    [SerializeField] private Button botaoAgradecimentos;
    [SerializeField] private Button botaoSair;
    [SerializeField] private Button botaoVoltar;
    [SerializeField] private Button botaoVoltarAgradecimentos;
    [SerializeField] private Button botaoVoltarLabirintos;
    [SerializeField] private Button botaoLabirinto01;
    [SerializeField] private Button botaoLabirinto02;
    [SerializeField] private Button botaoLabirinto03;

    [SerializeField] private GameObject menuPrincipal;
    [SerializeField] private GameObject menuCreditos;
    [SerializeField] private GameObject menuAgradecimentos;
    [SerializeField] private GameObject menuLabirintos;
    // Start is called before the first frame update
    void Start()
    {
        IniciarListenersBotoes();
        VoltarMenuPrincipal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnButtonJogarClick()
    {
        CarregarCena();
    }

    private void OnButtonCreditosClick()
    {
        CarregarCreditos();
    }

    private void OnButtonSairClick()
    {
        FecharJogo();
    }

    private void OnButtonVoltarClick()
    {
        VoltarMenuPrincipal();
    }

    private void OnButtonAgradecimentosClick()
    {
        CarregarAgradecimentos();
    }

    private void OnButtonLabirintosClick()
    {
        CarregarLabirintos();
    }

    private void OnButtonVoltarAgradecimentosClick()
    {
        VoltarMenuPrincipalAgradecimentos();
    }

    private void OnButtonVoltarLabirintosClick()
    {
        VoltarMenuPrincipalLabirintos();
    }

    private void OnButtonLabirinto01Click()
    {
        CarregarLabirinto01();
    }

    private void OnButtonLabirinto02Click()
    {
        CarregarLabirinto02();
    }

    private void OnButtonLabirinto03Click()
    {
        CarregarLabirinto03();
    }

    private void CarregarCena() {
        SceneManager.LoadScene("Scenes/Fase01", LoadSceneMode.Single);
    }

    private void CarregarLabirinto01()
    {
        SceneManager.LoadScene("Scenes/Labirinto01", LoadSceneMode.Single);
    }

    private void CarregarLabirinto02()
    {
        SceneManager.LoadScene("Scenes/Labirinto02", LoadSceneMode.Single);
    }

    private void CarregarLabirinto03()
    {
        SceneManager.LoadScene("Scenes/Labirinto03", LoadSceneMode.Single);
    }

    private void CarregarCreditos()
    {
        menuPrincipal.SetActive(false);
        menuCreditos.SetActive(true);
    }

    private void CarregarLabirintos()
    {
        menuPrincipal.SetActive(false);
        menuLabirintos.SetActive(true);
    }

    private void VoltarMenuPrincipal()
    {
        menuPrincipal.SetActive(true);
        menuCreditos.SetActive(false);
        menuAgradecimentos.SetActive(false);
        menuLabirintos.SetActive(false);
    }

    private void VoltarMenuPrincipalAgradecimentos()
    {
        menuPrincipal.SetActive(true);
        menuAgradecimentos.SetActive(false);
    }

    private void VoltarMenuPrincipalLabirintos()
    {
        menuPrincipal.SetActive(true);
        menuLabirintos.SetActive(false);
    }

    private void CarregarAgradecimentos()
    {
        menuPrincipal.SetActive(false);
        menuAgradecimentos.SetActive(true);
    }

    private void FecharJogo()
    {
        Application.Quit();
    }

    private void IniciarListenersBotoes()
    {
        botaoJogar.onClick.AddListener(OnButtonJogarClick);
        botaoCreditos.onClick.AddListener(OnButtonCreditosClick);
        botaoLabirintos.onClick.AddListener(OnButtonLabirintosClick);
        botaoAgradecimentos.onClick.AddListener(OnButtonAgradecimentosClick);
        botaoSair.onClick.AddListener(OnButtonSairClick);
        botaoVoltar.onClick.AddListener(OnButtonVoltarClick);
        botaoVoltarAgradecimentos.onClick.AddListener(OnButtonVoltarAgradecimentosClick);
        botaoVoltarLabirintos.onClick.AddListener(OnButtonVoltarLabirintosClick);
        botaoLabirinto01.onClick.AddListener(OnButtonLabirinto01Click);
        botaoLabirinto02.onClick.AddListener(OnButtonLabirinto02Click);
        botaoLabirinto03.onClick.AddListener(OnButtonLabirinto03Click);
    }


}
