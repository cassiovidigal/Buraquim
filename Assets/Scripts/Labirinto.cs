using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirinto : MonoBehaviour
{
    public int idCena;
    // Start is called before the first frame update
    void Start()
    {
        PreloadManager.InstanciaPreloadManager.SetUltimoLabirinto(idCena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
