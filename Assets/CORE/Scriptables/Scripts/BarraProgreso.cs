using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraProgreso : MonoBehaviour {


	 Slider Barra;
	public float Max;
	public float Actual;
	public Text valorString;


	void Start(){
		Barra = GetComponent<Slider> ();
	}


	void Update (){
		//Max = Actual;
		ActualizarBarra (Max, Actual); //actualizamos la barra con los valores que tienen las variables max y Actual

	}



	void ActualizarBarra(float valorMAx,float valorAct) {
		float porcentaje;
		porcentaje = Actual / Max;
		Barra.value = porcentaje;
		valorString.text = porcentaje * 100 + "%";
	}
	
}