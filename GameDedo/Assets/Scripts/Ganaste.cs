using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganaste : MonoBehaviour {

    // Use this for initialization
    bool flag = false;
    public GameObject camaraGameWin;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (flag == false)
        {
            if (other.tag == "Player")
            {
                flag = true;
                Marcador.llegoMeta = true;
                camaraGameWin.SetActive(true);
            }
        }
    }

}
