using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pollitoScript : MonoBehaviour {

    private Rigidbody2D fisicaPollito;
    public ControlMonedas codigoMonedas;

	// Use this for initialization
	void Start () {
        fisicaPollito = GetComponent<Rigidbody2D>(); //esto hace que si el pollito tiene fisica, que lo guarde en el inicio
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 fuerzaIzquierda = new Vector2(-10, 0);
            fisicaPollito.AddForce(fuerzaIzquierda);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 fuerzaDerecha = new Vector2(10, 0);
            fisicaPollito.AddForce(fuerzaDerecha);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 fuerzaAbajo = new Vector2(0, -10);
            fisicaPollito.AddForce(fuerzaAbajo);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 fuerzaArriba = new Vector2(0, 10);
            fisicaPollito.AddForce(fuerzaArriba);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Coin")
        {
            collision.gameObject.SetActive(false);
            codigoMonedas.AumentarMonedas();
        }
    }
}
