using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    // Use this for initialization
    public float velocidad = 0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Marcador.empezo == true) { 
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0,Time.time * velocidad);
        }
    }
}
