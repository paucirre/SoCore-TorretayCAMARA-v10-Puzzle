using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARMA : MonoBehaviour
{

	#region Variables Principales-------------------------------------------------------------------------
	[Header("Arma")]

	public float CadenciaDisparo;
	private float TiempoUltimoDisparo = 0;
	public int TiempoRecarga;
	public int ModoDisparo;
	public static bool enemigoOculto;

	public int AlcanceDeteccionArma;
	public Transform Bocacha;
	public GameObject LaserFlash;
	public int tiempoApagadoLaser;


	[Header("Audios")]//hace So
	private AudioSource Arma_Altavoz;
	public AudioClip Sonido_disparo;
	public AudioClip Sonido_descargada;
	public AudioClip Sonido_recargar;
	public AudioClip Sonido_Vacia;


	#endregion
	#region Variables Municion-------------------------------------------------------------------------------------

	public float retrasoEnDisparar;

	[Header("Municion")]
	public int MunicionActual;
	public int MunicionMax;
	public GameObject Bala_Noletal;
	public GameObject Bala_Estandar;// arrancar de aqui y poner en DB_FX_PROYECTILES?
	public GameObject Bala_Incendiaria;
	public GameObject Bala_Piercing;
	[Header("Calibre")]
	private int BalasEnAire = 0;
	public enum Calibre { PistolaCasera, Pistola, Rifle, Sniper, RPG, Escopeta, Flechas, AltoCalibre, Canon, };
	public Calibre calibre;
	public enum NombreTipoMuni { NoLetal, Estandar, Incendiaria, Piercing };
	public NombreTipoMuni TipoMuni;


	#endregion
	public GameObject ObjetivoApuntado;
	public SensorTorreSuave sensorPadre;
	public GameObject objetivoRecibidoDe_Sensor;
	

		void Update()
	{
		ComprobarLineaFuego();
		if (Input.GetKeyDown(KeyCode.Space))
        {            if (MunicionActual > 0)     {           DISPARA();    
            }
						else if (MunicionActual >= 0) { Arma_Altavoz.PlayOneShot(Sonido_descargada); }
        }
		if (Input.GetKeyDown("r")) { Invoke("RecargarArma", TiempoRecarga); Arma_Altavoz.PlayOneShot(Sonido_recargar); }
	}
		void Start()
		{
		//SensorTorreSuave sensorPadre = GetComponentInParent(typeof (SensorTorreSuave) as SensorTorreSuave);
		//sensorPadre = GetComponentInParent<SensorTorreSuave>(); Debug.Log("---=====================================================TengoSensorPadre============")  ;
		
		//TipoMuni = NombreTipoMuni.Estandar;
		Arma_Altavoz = GetComponent<AudioSource>(); Bocacha = GetComponentInChildren<Transform>();

		}
	
	
	
	
	
	public void DISPARA()
		{Debug.Log("                         ARMA dice:    Orden de disparo recibida");
		if (Time.time > TiempoUltimoDisparo && MunicionActual > 0)
			{
				//Debug.Log("                                   ARMA dice:   SI ya puedo dispara ha pasado tiempo y tengo muni");
				Debug.DrawLine(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), Color.magenta, AlcanceDeteccionArma);//dibuja una linea roja

				//Debug.Log("                                   ARMA dice:   a ver... que Tipo de municion tengo");
				switch (TipoMuni)
				{

					case NombreTipoMuni.NoLetal:
					GameObject Bala = Instantiate(Bala_Noletal, Bocacha.position, Bocacha.rotation);
					Bala.name = "Bala_" + BalasEnAire++;
					Debug.Log("                         ARMA dice:    BBBBBBUUUUUUUUUUUMMMMMMMMM!!!");
					if (MunicionActual > 0) { SonarDisparo(); }
						MunicionActual--;
						break;
					

				//GameObject Bala = Instantiate(Bala_Noletal, Bocacha.position, Bocacha.rotation);// as GameObject;//
					//serian balas disparadas ya que se suman		//Incrementa el numero de balas disparadas(para nombrar los clones)
				//Proyectil proyectil = Bala.GetComponent<Proyectil>(); ///////SE CREA VARIABLE TIPO DE LA CLASE QUE VA A ALMACENAR PARA PODER TOCAR SUS PARAMETROS
				//NOVA__if (proyectil == null) { BalasEnAire--; };//si el proyectil deja de existitir lo resta?


					case NombreTipoMuni.Estandar:
						Instantiate(Bala_Estandar, Bocacha.position, Bocacha.rotation);
							break;
					case NombreTipoMuni.Incendiaria:
						Instantiate(Bala_Incendiaria, Bocacha.position, Bocacha.rotation);
							break;
					case NombreTipoMuni.Piercing:
						Instantiate(Bala_Piercing, Bocacha.position, Bocacha.rotation);
							break;
				}
				TiempoUltimoDisparo = Time.time + CadenciaDisparo; //pone el tiempo del utimo disparo al momento actual+ tiempo cadencia
			}
		else if (MunicionActual <= 0) {
			//hacer un contador para que deje de sonar a los "10 clicks"
			SonarDisparo(); }
		
		}
	public void LaserFlashOn()
		{
			LaserFlash.SetActive(true);
			Invoke("LaserFlashOff", tiempoApagadoLaser);
		}

    void ComprobarLineaFuego2()
    {

        if ((sensorPadre.ObjetivoActual = null) && (!sensorPadre.ultimoObjetoLista)) { sensorPadre.RelajarTorreta(); }
        else
        {
            Debug.Log("---==============================ARMA VISION:==============================================HayObjetivo en el padre------------------------------------------------------");
            RaycastHit RayArmaVision;
            if (Physics.Raycast(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), out RayArmaVision, AlcanceDeteccionArma))
            {
                //	Debug.Log("---========================ARMA VISION:   ==================================NOMBRE DE COLISIONNNNNN de VISION" + RayArmaVision.transform.name);
                //Debug.Log("---========================ARMA VISION:   ==================================NOMBRE DE COLISIONNNNNN de OBJETIVOPrincipal" + sensorPadre.ultimoObjetoLista.name);
                if ((sensorPadre.ultimoObjetoLista) && (RayArmaVision.transform.name == sensorPadre.ultimoObjetoLista.name))
                {
                    //	Debug.Log("---========================ARMA VISION:   =================================ESSSS == Objetivo actiual============================================================================================");
                    //Debug.DrawRay(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), Color.red, AlcanceDeteccionArma);
                    LaserFlashOn();
                    DISPARA();

                }
            }

            //if (RayArmaVision.transform.tag == "Amigo") { Debug.DrawRay(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), Color.blue, AlcanceDeteccionArma); }

        }

    }
    public void ComprobarLineaFuego()
    {
		Debug.Log("                                           Comprobando LINEAAAAA DE FUEGOOOOO");
        //Debug.DrawRay(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), Color.white, AlcanceDeteccionArma);                //Dibuja: Blanco guia de direccion 
        if (Time.time - CadenciaDisparo >= TiempoUltimoDisparo)  


			//Si 				
        {
            RaycastHit RayColision;
            if (Physics.Raycast(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), out RayColision, AlcanceDeteccionArma))
            {

				ObjetivoApuntado = RayColision.transform.gameObject;
				Debug.Log("                                ARMA: Ultimo objetivo Apuntado = a la colision"+ RayColision.transform.name);
				if (RayColision.transform.tag == "Enemigo")
				{
					Debug.Log("                                           ENEMIGO A TIRO!!!!");
					//Debug.DrawRay(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), Color.red, AlcanceDeteccionArma);
					enemigoOculto = false;

				}
                else { enemigoOculto = true; }
                LaserFlashOn();
				sensorPadre.ComprobarVida();

                if (RayColision.transform.tag == "Amigo") { Debug.DrawRay(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), Color.blue, AlcanceDeteccionArma); }

            }
        }
    }

	void LaserFlashOff() { LaserFlash.SetActive(false); }
	void SonarDisparo()
	{
        if (MunicionActual > 0) { Arma_Altavoz.PlayOneShot(Sonido_disparo); }	
		if (MunicionActual <= 0) 	{  if (Arma_Altavoz.isPlaying == false)	{	Arma_Altavoz.PlayOneShot(Sonido_descargada);}	}
	}
	void RecargarArma() { MunicionActual =(MunicionActual + 20); Arma_Altavoz.PlayOneShot(Sonido_recargar); }

	void DisparaMisil(GameObject ObjetivoMisil)
	{
		if (Time.time > TiempoUltimoDisparo && MunicionActual > 0)
		{

			GameObject Misil = Instantiate(Bala_Noletal, Bocacha.position, Bocacha.rotation);
			Misil.name = "Misil_";// + BalasEnAire++
								  //Misil.ObjetivoSeguimiento = 
								  //GameObject.Instantiate(Bala_Noletal, Bocacha.transform.position, Bocacha.transform.rotation);
			if (MunicionActual > 0) { SonarDisparo(); }
			TiempoUltimoDisparo = Time.time + CadenciaDisparo; //pone el tiempo del utimo disparo al momento actual+ tiempo cadencia
		}
		else if (MunicionActual <= 0)
		{// Debug.Log("sonando else if muni <0");
		 //hacer un contador para que deje de sonar a los "10 clicks"
			SonarDisparo();
		}

		//else if (MunicionActual <= 0)
		//{
		////___________________Sonido descargada..
		////Arma_Altavoz.PlayOneShot(Sonido_descargada);
		////Arma_Altavoz.clip = Sonido_descargada;

		//MunicionActual = 0;

		//}
	}//busca componente Utensilio en hijo (del que deriva arma)y activa su funcion usar}


}




//se repite el if del tiempo en la funciond e disparar y en la del rayo..pk?
//crear un objeto vacio llamado "balas" del que se hacen hijas las balas y los agujeros que dejan
