using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
    }
    public void GoToSettingMenu(){
    	//SceneManager.LoadScene("OtroMenu");
    }
    public void GoToMainMenu(){
    	SceneManager.LoadScene("MenuScene");
    }
    public void QuitGame(){
    	Application.Quit();
    }
}






