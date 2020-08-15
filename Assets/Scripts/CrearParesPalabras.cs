using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CrearParesPalabras : MonoBehaviour
{
	public Transform CasillasParent;
	public GameObject palabra1;
	public GameObject palabra2;
	public GameObject palabra3;
	public GameObject palabra4;
	public GameObject palabra5;
	public GameObject palabra6;
	public GameObject palabra7;
	public GameObject palabra8;

	private string[] palabras ={"SOL","PILA","CAMA","GATO","BOTE","ALA","RUTA","SAPO"};

	public Text intentos;
	public int contadorClics=0;
    // Start is called before the first frame update
    void Start()
    {
        generando();
    }

    public void Mostrar(){
    	int ran;
   		List<int> lista  = new List<int>();
    	for(int i = 0 ; i<4;i++){
    		ran = Random.Range( 0, palabras.Length);
    		int test = 0;
    		foreach(int item in lista){
            	if(item == ran){
            		test=1;
	            	i=i-1;
            	}
        	}
        	if(test == 0)
        		lista.Add(ran);
    	}
    	foreach(int item in lista){
            print(item);
        }
		palabra1.GetComponent<TextMeshProUGUI> ().text = palabras[lista[0]];
		palabra2.GetComponent<TextMeshProUGUI> ().text = palabras[lista[0]];
		palabra3.GetComponent<TextMeshProUGUI> ().text = palabras[lista[1]];
		palabra4.GetComponent<TextMeshProUGUI> ().text = palabras[lista[1]];
		palabra5.GetComponent<TextMeshProUGUI> ().text = palabras[lista[2]];
		palabra6.GetComponent<TextMeshProUGUI> ().text = palabras[lista[2]];
		palabra7.GetComponent<TextMeshProUGUI> ().text = palabras[lista[3]];
		palabra8.GetComponent<TextMeshProUGUI> ().text = palabras[lista[3]];
	}


	public void generando(){
		int cont = 0,ran;
		//palabra1.transform.position = new Vector3(0, 0, 0);
		for(int i=0;i<3;i++){
			for(int x = 0;x<3;x++){
				//palabra1.GetComponent<TextMeshProUGUI> ().text = palabras[1];
				GameObject casillaTemp = Instantiate(palabra1, new Vector3(x,0,i),Quaternion.identity);	
				//ran = Random.Range( 0, keyword.Length); //se genera numero aleatorio --rango numero de letras de abcdario
				//casillaTemp.GetComponent<Casilla> ().idLetterCasilla  = ran;
				//casillas.Add(casillaTemp);
				//casillaTemp.GetComponent<Casilla> ().NumCasilla = cont;
				casillaTemp.transform.parent = CasillasParent;
				casillaTemp.transform.position = new Vector3(0, 0, 0);
				cont++;
			}
		}
	} 

	public void AsignarTexto(string letra_){
		//AQUI SEGUN INDICACIONES DEL DOCENTE (POR CONSULTAR) SE DISTRIBUIRAN LAS LETRAS ???
	}

	public void AumentarContador(){
		contadorClics++;
		ActualizarUI();
	}
	public void ActualizarUI(){
		intentos.text = "Intentos : " + contadorClics;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
