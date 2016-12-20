using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTouch : MonoBehaviour {
	public float speed=0.1f;
    bool mousePressed;
    int valMax = -9999;

    //bool presionado = false;
    int countFinger = 0;
    // Use this for initialization
    private Touch touch;
    public TextMesh puntuacion;

    //public GameObject ParticulaLuz;
	void Start () {
        //speed = 0.20f;
        
	}

    void OnMouseOver()
    {
        if (mousePressed)
        {
            Marcador.empezo = true;
            var pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -1.41f));
            transform.position = new Vector3(pos.x,pos.y,-1.41f);
            int distancia = (int)transform.position.y;
            if (distancia > valMax) {
                valMax = distancia;
                puntuacion.text = (int)transform.position.y + "";
            }
      //      presionado = true;
            countFinger = 1;
            
    
        }
    }
    
     void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            mousePressed = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            mousePressed = false;
            if (countFinger == 1) {
                //countFinger = 2;
                if (Marcador.llegoMeta == true)
                {
                    Marcador.choco = false;
                }
                else { 
                Marcador.choco = true;
                }
            }
            
        }

        
    }
    

}
