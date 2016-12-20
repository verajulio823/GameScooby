using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PresioneJugar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown() {
        
        Marcador.choco = false;
        Marcador.Contador = 3;
        Marcador.llegoMeta = false;
        SceneManager.LoadScene("Scroll");

    }
}
