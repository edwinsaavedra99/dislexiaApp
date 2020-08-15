using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casilla : MonoBehaviour
{
    public Material colorCasilla;
    public Material colorCasillaPush;
	public int NumCasilla = 0;
	public int idLetterCasilla = -1;
	public GameObject crearCasilla;
	private bool pulsado=false;

	void Awake(){
		crearCasilla = GameObject.Find("Scripts");
	}

	/**
	*Metodo de Evento Touch: Al pulsar cada casilla
	*/
	void OnMouseDown(){
		print (NumCasilla.ToString());
		PonerColor();
		
	}
	/**
	*Metodo de PonerColor: Cambia el Material de una casilla
	*y aumenta el contador de intentos cada ves que se ejecuta
	*/
	public void PonerColor(){
		if(crearCasilla.GetComponent<CrearCasilla>().getLetterImput() == idLetterCasilla){
			//Solo cambia el material si el ID de la letra conincide con el imput
			GetComponent<MeshRenderer> ().material = colorCasillaPush;
			if(!pulsado){
				pulsado=true;
				crearCasilla.GetComponent<CrearCasilla>().AumentarContador();
			}
		}else{
			//Solo se aumenta el contador si la casilla no fue seleccionada antes
			crearCasilla.GetComponent<CrearCasilla>().AumentarContador();
		}
	}
}
