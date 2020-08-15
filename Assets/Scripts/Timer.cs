using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public Text tiempoText;
    public float tiempo = 0.0f;
    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        tiempoText.text = "Tiempo : " + tiempo.ToString("f0");
    }
}
