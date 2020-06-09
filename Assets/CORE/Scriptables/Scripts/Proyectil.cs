using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    #region VARIABLES_____________________________________________________________________
    private Rigidbody bulletRB;
    public float velocidad;
    public float TiempoVida;
    public string TagColisionado;
    public string MaterialColisionado;
    public float DamageRandom;

    public int FuerzaPenetracion;
    //Alguna clase de referencia a quien ha disparado y a su controlador del canvas para poner el puntero de otra forma si ha dado en el objetivo.

    public AudioClip ImpactoGen; //hacerSo DB
    public AudioClip ImpactoPlayer;
    public AudioSource AltavozBala;

    [Header("Daños")]
    public float Dama_Personajes;
    public float Dama_Vehiculos;
    public float Dama_Edificios;
    public float Dama_Blindajes;
    //public float DañoEscudos; 
    #endregion
    //__________________________________________________REFERENCIA A DB_SONIDOS PROYECTIL PARA DIFERENTES COLISIONES EN TERRENOS
    void Awake() { bulletRB = GetComponent<Rigidbody>(); }
	void Start()
	{	bulletRB.velocity = transform.forward * velocidad;
		//????gameObject.GetComponent<Animator>().enabled=false; //Cmbiar el estado del animator pero deberia ser a traves del gestor de movimientos y salud "
		DamageRandom = Random.Range(1, 5);
		ApagadoBala();//Invoke ("ApagadoBala",TiempoVida);
	}
	 
    void OnTriggerEnter(Collider other)
    {
		TagColisionado = other.gameObject.tag;
		
		if (other.GetComponent<Salud>() != null)
		{ Salud _Salud = other.GetComponent<Salud>();

			switch (TagColisionado)
			{
				case "Enemigo":
					//Debug.Log("Proyectil:  EnemigoALCANZADO!!!!");
					other.gameObject.GetComponent<Salud>().Vida -= Dama_Personajes + DamageRandom;// Debug.Log("Proyectil:Le resto daño random");
					_Salud.Vida -= Dama_Personajes + DamageRandom;

					AltavozBala.PlayOneShot(ImpactoGen);

					if (_Salud.Vida < 0) { }
					Destroy(this.gameObject, 0);
					break;
				case "Vehiculo":
                    other.gameObject.GetComponent<Salud>().Vida -= Dama_Vehiculos + DamageRandom;
                    break;
                case "Estructura":
                    other.gameObject.GetComponent<Salud>().Vida -= Dama_Edificios + DamageRandom;
                    break;
                case "Blindaje":
                    other.gameObject.GetComponent<Salud>().Vida -= Dama_Blindajes + DamageRandom;
                    break;
				case "Terrain":
					AltavozBala.PlayOneShot(ImpactoGen); Destroy(this.gameObject);
					break;



			}
		}
		else {
			AltavozBala.PlayOneShot(ImpactoGen);
//			Debug.Log("                                               PROYECTIL:  No esta entre los TAGS definidos, se llama" + other.name) ;
			//Destroy(this.gameObject);
		}

	}
	//void OnTriggerEnter(Collider other)
		//{                              

		//	//_______x Tag

		//	TagColisionado = other.gameObject.tag;//almacena el tag para el switch
		//	//.RecibirBalazo();//le deberia de pasar el daño y el tipo de daño por parametros, y determinarlo segun casos

		//	//Si tiene componente de salud, y si bala es daño/Fuego/Radiacion/impacto__________________IMPORTANTE
		//	if (other.GetComponent<Salud>() != null) {//comprueba que el objeto colisionado tiene el componente
		//		Salud _Salud = other.GetComponent<Salud>();

		//		switch (TagColisionado)
		//	{
		//		case "Enemigo":
		//				Debug.Log("Proyectil:  EnemigoALCANZADO!!!!");
		//				other.gameObject.GetComponent<Salud>().Vida -= Dama_Personajes + DamageRandom; Debug.Log("Proyectil:Le resto daño random");
		//                   _Salud.Vida -= Dama_Personajes + DamageRandom;
		//                   if (_Salud.Vida<0) { Debug.Log("Proyectil:Le MATEEEEEEEEEEE"); }
		//				break;
		//		/*case "Vehiculo":
		//			other.gameObject.GetComponent<Salud>().Vida -= Dama_Vehiculos + DamageRandom;
		//			break;
		//		case "Estructura":
		//			other.gameObject.GetComponent<Salud>().Vida -= Dama_Edificios + DamageRandom;	
		//			break;
		//		case "Blindaje":
		//			other.gameObject.GetComponent<Salud>().Vida -= Dama_Blindajes + DamageRandom;
		//			break;	*/	}	
		//		}
		//	else { Debug.Log("Proyectil:  No se que es pero no parece estar vivo o tener utilidad"); }
		//	//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>other.gameObject.GetComponent<Salud>().RecibirBalazo();

	public void DestruirBala() { Destroy(this.gameObject); }
	public void ApagadoBala() { Destroy(this.gameObject, TiempoVida); }
	public void DetectaMaterialColisionado()
	{
		//MaterialColisionado = other.material.name;  //Ejecuta sonido por colision
		//switch (MaterialColisionado)
		//{
		//	case "Tierra":
		//		break;
		//	case "Madera":
		//		break;
		//	case "Carne":
		//		break;
		//	case "Metal":
		//		break;
		//	case "Agua":
		//		break;
		//	case "Cristal":
		//		break;
		//	case "Roca":
		//		break;
		//		//para desactivar componentes      other.gameObject.GetComponent<Salud>().enabled = false;
		//}
	}
}
	//	DestruirBala();

		
		
	
