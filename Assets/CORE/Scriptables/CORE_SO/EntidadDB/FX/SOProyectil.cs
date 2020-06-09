using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Proyectil", menuName = "Entidad/FX/Proyectil")]
public class SOProyectil : Entidad
{

	/*OBJETIVOS: 
	que cada proyectil llame a un sonido,particulas, instancie un agujeroGameObj/o/proyector(a una distancia del punto de colision y mirando hacia el.)*/




	public enum TipoDamage { Radiaccion, Fuego, Impacto, Aplastado, Asfixia, Enfermedad }
	public TipoDamage tipoDamage;//acede al contenido de la variable anterior


	//private Rigidbody BalaRB;
	public float velocidad;
	public float TiempoVida;
	public bool sangrante;

	[Header("DAÑOS")]

	public float Damage_Energia; //Escudos
	public float Damage_Salud;
	public float Damage_Vehiculos; //blindajes
	public float Damage_Estructuras;
	public float Damage_Animal;

	[Header("Holes")] // cada tipo de proyectil puede dejar una marca diferente en el terreno
	public GameObject[] Hole_TCristal;
	public GameObject Hole_Madera;
	public GameObject Hole_Chapa;
	public GameObject Hole_Metal;

	
	
	//public float Damage_max ;
	//public float Damage_min ;


	/*Comportamiento Proyectil no funciona en scriptableObject
	void Start()
	{
	   
	Damage_max = Damage_Salud + 3;	//Se declara el random del tipo de daño (deberia ir al aplicarlo para que cada vez sea distinto)
	Damage_min = Damage_Salud - 3;


	BalaRB = GetComponent <Rigidbody> ();
		BBalaRB.velocity = transform.forward * velocidad;	//Toma rigid body 2d y le aplica un movimiento constante en la dirección UP a la velocidad que tiene la bala

	}


	void Update()
	{
		Damage_Salud = Random.Range(Damage_max, Damage_min);
		Damage_Energia = Random.Range(Damage_max, Damage_min);
		Destroy(gameObject, TiempoVida);
	}
	//HACER ESTO COMO CASOS 1-PERSONAS 2-VEHICULOS 3-EDIFICIOS...

	void OnTriggerEnter2D(Collider2D other)	{								//	Debug.Log ("colision detectada");
		if (other.CompareTag("Player") || other.CompareTag("PlayerP"))
		{																	//	Debug.Log ("ha eres un player");
			other.gameObject.GetComponent<Salud>().Vida -= Damage_Salud;          //	Debug.Log ("vida -----------------------------------------");
			other.gameObject.GetComponent<Salud>().RecibirBalazo();
			//para desactivar componentes      other.gameObject.GetComponent<Salud>().enabled = false;

			DestruirBala();

		}

	}
	void DestruirBala()
	{
		Destroy(this.gameObject);
	}
	*/

}
