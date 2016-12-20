using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour {

    bool flag = false;
    float[] listSangreOpacity = new float[3]  { 0.5f, 0.75f, 0.9f };
    void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (flag == false) { 
    
            if (other.tag == "Player")
            {
                Marcador.choco = true;
                flag = true;
                float x =  other.gameObject.transform.position.x;
                float y =  other.gameObject.transform.position.y;

                Debug.Log("X =" + x + " Y= "+y + " Tamaño : "+ listSangreOpacity.Length);
                float opacity=listSangreOpacity[Random.Range(0, listSangreOpacity.Length)];
                Debug.Log("OPACITYYYYYYYYYYYY " +opacity);

                Marcador.listSangre.Add(new Sangre(x, y,opacity,Random.Range(0,10)));

    
            }
        }
    }
}
