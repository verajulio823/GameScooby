using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marcador
{

    public static List<Sangre> listSangre = new List<Sangre>();
    // Variable estatica que almacena la cantidad de vidas que estan disponibles para el juego
    public static int Contador = 3;
    // Variable estatica que controla que el carro se inicialice invicto a choque
    public static bool choco = false;
    // Variable estatica que controla y notifica que el carro no ah llegado a la meta
    public static bool llegoMeta = false;
    // Variable estatica que almacena la direccion que el carro debe seguir cuando colisiona con una notificacion de aviso de bifurcacion
    public static string direccion = "";
    // variable estatica que almacena el valor si empezo el game
    public static bool empezo = false;

   

}
