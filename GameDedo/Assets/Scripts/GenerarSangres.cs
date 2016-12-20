using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarSangres : MonoBehaviour {

    public GameObject[] listSangre;
	// Use this for initialization
	void Start () {
        generarSangre();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void generarSangre() {
        for (int i = 0; i < Marcador.listSangre.Count; i++) {
            
            Vector3 position = new Vector3(Marcador.listSangre[i].getX(), Marcador.listSangre[i].getY(), -1.3f);
            GameObject go = listSangre[Marcador.listSangre[i].getTipo()];            
            go.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f, Marcador.listSangre[i].getOpacity());            
            Instantiate(go,position, new Quaternion(0.0f,0.0f,0.0f,0.0f));
        }
    }

}
