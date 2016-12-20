using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BotonVolverEmpezar : MonoBehaviour {

    // Use this for initialization
    public GameObject camaraGameOver;
    public GameObject huella;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnMouseDown()
    {
        Marcador.choco = false;
        Marcador.empezo = false;
        huella.SetActive(true);
        camaraGameOver.SetActive(false);
        
        SceneManager.LoadScene("Intro");
    }
}
