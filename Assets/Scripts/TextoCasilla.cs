using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TextoCasilla : MonoBehaviour
{
    public Material colorCasilla;
	public int NumCasilla = 0;


	/**
	*Metodo Start, es lo primero que se ejecuta en el Script:
	*Rota 90 grados en el eje X al componente TextoCasilla
	*/
	void Start () {
       transform.Rotate(90, 180, 180);   
    }
    /**
	*Metodo de Evento Touch: Al pulsar cada texto casilla
	*/
	void OnMouseDown(){
		print (NumCasilla.ToString());
	}


	public void PonerTexto(string texto){
		GetComponent<TextMesh> ().text = texto;
		print(texto);
	}
}


