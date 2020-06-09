using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Salud : MonoBehaviour {
    #region VARIABLES________________________________
    //FISICAS
    private Rigidbody rb;
    public Animator anim;
    public bool Muerto;
	public int TiempoDestruir;
    //VIDA

    public GameObject effect;
    public float Vida;
    //public Slider BarraVida;
    //private int bucle_morir= 1;

    //public GameObject Reseteador;

    //AUDIO
    public AudioSource AudioFuente;
    public AudioSource AudioFuente2;
    public AudioClip Morir;
    public AudioClip Chapoteo;
    public Material Colorcubo;

    #endregion

    /*private void Start (){
		//Vida = Vida;
		//rb = GetComponent<Rigidbody> ();
		//FadeAnimator = FADeobj.GetComponent<Animator> ();////////////////////////////////////////////////////////////////////////////////
		
	}*/
    private void Start()   {
		//Colorcubo = this.GetComponentInParent<Material>();
		//Colorcubo.SetColor("_Color", Color.blue);
		Muerto = false;
	}
    void Update(){	//BarraVida.GetComponent<BarraProgreso> ().Actual=Vida;	
		if (Vida <= 0)  {
			//Debug.Log("vida bajo 000000000000000000000000000000000000000000");
			if (!Muerto) { 
				GameObject EfectoHumo = Instantiate(effect, this.transform.position, this.transform.rotation) as GameObject;
				EfectoHumo.transform.parent = this.transform; Muerto = true;
			}
			Invoke("MORIRSE", TiempoDestruir);
			
			//Instantiate(effect, this.transform.position, this.transform.rotation,Transform.parent);
			
			
			//Colorcubo.SetColor("_Color", Color.red) ;
			/*rb.gravity = 0;
		//gameObject.GetComponentInParent<PlayerControlA>().enabled = false;
			//AudioFuente.clip = Chapoteo;
				//AudioFuente.Play ();

				//FadeOutMuerto.SetBool("FadeOutMuerto", true);*/

		}
	}


   void MORIRSE(){
		//Debug.Log("                                               SALUD:    mueroooooooooooooooooooooooooooooooooooooooo");
		//anim.SetBool("Muerto",true);
		//Reseteador.SetActive (true);
		//bucle_morir = 0;
		//FadeAnimator.SetBool ("FadeOutMuerto", true);
		//AudioFuente.clip = Morir;
		//AudioFuente.Play ();
		//Destroy(this.gameObject);                                      /////////////////////////////////AudioFuente2.PlayOneShot;
		//Destroy(this,0);
		Destroy(this.gameObject,0);
	}
		public void RecibirBalazo (){
		

		if (Vida <= 0.0f ) {
			AudioFuente.clip = Morir ;
			AudioFuente.Play ();
			MORIRSE();
			//Debug.Log ("RECIBIR BALAZO FUNCIOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOONNNS");
		}

		//AudioFuente.clip = Golpe;
		//AudioFuente.PlayOneshot (morir);
	}


}

