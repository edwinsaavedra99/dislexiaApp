using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearCasilla : MonoBehaviour{
	public GameObject CasillaPrefab;
	public GameObject TextoPrefab;
	public Transform CasillasParent;
	public int Ancho,Alto;
	public Material Blanco;
	public Material Negro;
	private char[] keyword = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','X','Y','Z'};
	private List<GameObject> casillas  = new List<GameObject>();
	private char imput = 'D';
	private int indexImput = 3;
	public Text intentos;
	public int contadorClics=0;

	/**
	*Metodo Start, es lo primero que se ejecuta en el Script:
	*Inicia al método Crear()
	*/
	void Start(){
		Crear();
	}
	/**
	*Metodo Crear:genera un componente copia de un prefab casilla y letra casilla
	*, asigna a cada casilla
	*un identificador - lo cual lo hace corresponder con una letra
	*/

	public void Crear(){
		int cont = 0,ran;
		for(int i=0;i<Alto;i++){
			for(int x = 0;x<Ancho;x++){
				GameObject casillaTemp = Instantiate(CasillaPrefab, new Vector3(x,0,i),Quaternion.identity);	
				GameObject casillaTempTexto = Instantiate(TextoPrefab, new Vector3(x,0,i),Quaternion.identity);
				ran = Random.Range( 0, keyword.Length); //se genera numero aleatorio --rango numero de letras de abcdario
				casillaTemp.GetComponent<Casilla> ().idLetterCasilla  = ran;
				casillaTempTexto.GetComponent<TextoCasilla> ().PonerTexto( keyword [ran] + "");
				casillas.Add(casillaTemp);
				casillaTemp.GetComponent<Casilla> ().NumCasilla = cont;
				casillaTempTexto.GetComponent<TextoCasilla> ().NumCasilla = cont;
				casillaTemp.transform.parent = CasillasParent;
				casillaTempTexto.transform.parent = CasillasParent;
				cont++;
			}
		}
	}
	public void AsignarTexto(string letra_){
		//AQUI SEGUN INDICACIONES DEL DOCENTE (POR CONSULTAR) SE DISTRIBUIRAN LAS LETRAS ???
	}


	public int getLetterImput(){
		return indexImput;
	}


	public void AumentarContador(){
		contadorClics++;
		ActualizarUI();
	}
	public void ActualizarUI(){
		intentos.text = "Intentos : " + contadorClics;
	}

}