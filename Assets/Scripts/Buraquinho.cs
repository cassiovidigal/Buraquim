using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buraquinho : MonoBehaviour
{
    private string pastaCenas = "Scenes/";
    private CircleCollider2D circleCollider;
    [SerializeField] private string proximaFase;

    // Start is called before the first frame update
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("teste");
        if (collision.tag == "Player")
        {
            EncerrarFase();
        }
    }
    
    private void EncerrarFase()
    {
        StartCoroutine(EncerrarFaseCoroutine());
    }

    private IEnumerator EncerrarFaseCoroutine()
    {

        Cronometro.InstanciaCronometro.PausarCronometro();
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(pastaCenas+proximaFase, LoadSceneMode.Single);

    }
}
