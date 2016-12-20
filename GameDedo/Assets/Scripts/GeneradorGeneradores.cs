using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorGeneradores : MonoBehaviour {


    public GameObject generador;
    // Use this for initialization
    void Start () {
        generarGeneradores();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void generarGeneradores (){
        float y= 12.24f;        
        for (int i = 1; i < 12; i++) {
            //y = y * i;
            Instantiate(generador, new Vector3(2.94f, y*i, -1.4f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));             
        }

    }


}
