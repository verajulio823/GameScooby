using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplazarCamara : MonoBehaviour {

	public Transform dedo;
	public float separacion;
	private float velodidad=0.05f;

	void Update () {
        if (Marcador.empezo == true) { 
		transform.position = new Vector3 (2.94f,transform.position.y+velodidad,-10.0f);
        }
    }

}
