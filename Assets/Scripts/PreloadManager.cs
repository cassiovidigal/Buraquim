using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreloadManager : MonoBehaviour
{

    private float[] temposFases;

    private static PreloadManager _instanciaPreloadManager;
    [SerializeField] public static GameObject instanciaPreloadManager;
    public static PreloadManager InstanciaPreloadManager
    {
        get
        {
            if (_instanciaPreloadManager == null)
            {
                _instanciaPreloadManager = instanciaPreloadManager.GetComponent<PreloadManager>();
            }
            return _instanciaPreloadManager;
        }
    }

    private void Awake()
    {
        instanciaPreloadManager = FindObjectOfType<PreloadManager>().gameObject;
        DontDestroyOnLoad(instanciaPreloadManager);
    }
    // Start is called before the first frame update
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        temposFases = new float[10];

        SceneManager.LoadScene("Scenes/Fase0", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SalvarTempoFase(int index, float tempo)
    {
        temposFases[index] = tempo;
    }
}
