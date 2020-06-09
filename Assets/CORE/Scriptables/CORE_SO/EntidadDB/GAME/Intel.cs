using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//AitorTorresLobato
public class Intel : MonoBehaviour
{
	//Se define desde imput field o o se puede hacer SO
	[Header("Briefing")]
	public string BriefingNombre;   //Nombre con el que se guardara la partida
	public string BriefingDescripcion;
	//public float resistanceWest ; //=0 neutras =1 equipo 1 =2 equipo2
	[Header("Climatologia")]
	[Range(0,100)]
	public float ClimaInicial ;
	[Range(0, 100)]
	public float NieblaInicial ;
	public float ClimaPosterior ;
	public float NieblaPosterior ;
	[Header("Fecha")]//inicial o al guardar partida
	public int year =2008;
	public int mes =10;
	public int dia =11;
	public int hora =14;
	public int minuto =20;

	//
	//Constructor// iguala todas las variables a los datos obtenidos
	//____________________________

	public Light Sol;
	public WindZone[] VientoZonas;
	public Shader Nubes;
	public Shader Agua;
	public AudioSource SonidosAmbiente;// se superpondran los sonidos de las "zonas"
	// public DB_SonidosAmbiente DBAmbiente; // El SO donde estan los sonidos de este mapa Dia tardes y noches
																//ROTACION SOLAR //POR CODIGO O POR ANIMACION???

}
