using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlMonedas : MonoBehaviour {

    public Text textoMonedas;
    private int contadorMonedas;

	// Use this for initialization
	void Start () {
        contadorMonedas = 0;

    }
	
	// Update is called once per frame
	/*void Update () {
		
	}*/

    public void AumentarMonedas()
    {
        contadorMonedas++;
        textoMonedas.text = "Monedas: " + contadorMonedas;
    }
}
