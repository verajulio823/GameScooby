using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObstaculos : MonoBehaviour {
    public GameObject[] obstaculos;
    //Variable GameObject generadorDerecho que se encargara de cargar un prefab de un animal en la via derecha de la autopista
    public GameObject generador1;
    public GameObject generador2;
    public GameObject generador3;
    //Variable GameObject generadorIzquierdo que se encargara de cargar un prefab de un animal en la via izquierda de la autopista
    //public GameObject generadorIzquierdo;
    //Variable flag que servira para controlar la generacion de animales
    public bool flag = false;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        generar();	
	}

    public void generar()
    {
        //	GameObject animal = animalito [Random.Range (0, animalito.Length)];
        //	generadorDerecho = Instantiate (animal, generadorDerecho.transform.position, Quaternion.identity) as GameObject;
        if (flag == false)
        {
            flag = true;
            
            GameObject obs = obstaculos[Random.Range(0, obstaculos.Length)];

            int valor =Random.Range(0, 3);
            if (valor ==1) {
                generador1 = Instantiate(obs, generador1.transform.position, generador1.transform.rotation) as GameObject;
            }
            if (valor == 2) {
                generador2 = Instantiate(obs, generador2.transform.position, generador2.transform.rotation) as GameObject;

            }
            if (valor == 3) {
                generador3 = Instantiate(obs, generador3.transform.position, generador3.transform.rotation) as GameObject;
            }
            

            
        }

        //GameObject pista = animalito [Random.Range (0, animalito.Length)];
    }
}
