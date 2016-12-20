using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraGameOver : MonoBehaviour
{
    public GameObject camaraGameOver;
    public GameObject huella;



    void Awake() {
        camaraGameOver.SetActive(false);
    }
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Marcador.choco == true)
        {
            camaraGameOver.SetActive(true);
        }
        if (Marcador.empezo == true) {
            huella.SetActive(false);        
        }
    }
}
