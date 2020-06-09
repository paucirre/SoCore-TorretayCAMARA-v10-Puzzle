using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;

public class SensorTorre : MonoBehaviour
{
    public DBAudioSensor BD_AUDIO;        // Declara el SO
    private Transform ObjetivoActual;

    public Transform Torreta;
    public Transform Can;

  public int VelocidadGiro = 200;
       
    private AudioSource AltavozSensor;   //Audiosource que buscara en el padre

    [Header("LISTAS DE OBJETIVOS DETECTADOS")]

    public List<Transform> ListaEnemigos = new List<Transform>();
    public List<Transform> ListaAmigos = new List<Transform>();

   //[Header("Objetivo")]

                                       //public Vector3 newtarget;
    //public Vector3 PunteroLaser;
    private void Start()  {  AltavozSensor = this.GetComponentInParent<AudioSource>(); }
    //Busca en el padre el componente audiosource en start


    public void FixedUpdate()
    {

        if (ObjetivoActual)
        {
            Vector3 PunteroLaser; //try { Vector3 PunteroLaser = ObjetivoActual.position; }----Vector3 PunteroLaser = ObjetivoActual.position;
            PunteroLaser.x= ObjetivoActual.position.y;
            PunteroLaser.z = ObjetivoActual.position.z;
            PunteroLaser.y = Torreta.transform.position.y;          //Ahora le pone la variable y en tranf.pos
            Torreta.transform.LookAt(PunteroLaser * Time.deltaTime );         //hace que la torreta mire hacia el objetivo de la variable que tiene la y a la misma altura que la propia torreta

            //Nova---Torreta.transform.Rotate(PunteroLaser* Time.deltaTime);///((((((((((((((((((PORAQUI VA LA COSA

            PunteroLaser.y = Can.position.y; //ahora Si, igualamos el eje Y a la posicion del objetivo (para el cañon)
            PunteroLaser.x = Can.position.y;
            PunteroLaser.z = ObjetivoActual.position.y;
            Can.transform.LookAt(PunteroLaser * Time.deltaTime);
        }        //(Gira el cañon con todas las variables ahora hacia el objetivo) y asi se repite el bucle
        else { Debug.Log("no hay objetivos"); }
    }

    private void Update ()

    {




        //PunterLaser.y = ObjetivoActual.transform.position.y;
        // Can.transform.rotation = Quaternion.Lerp (Can.transform.rotation,rot,  VelocidadGiro * Time.deltaTime);
        //¿¿¿¿¿Can.transform.rotation = PunterLaser.y;????PK no va esto?





        /*______________________________________METODO A______________________________________________________________________________________________Nova
         * Vector3 PunterLaser = (ObjetivoActual.transform.position);      //Crea el vector al que apuntar llamado Laser que es vector3 datos.
                                                                       //Pone uno de sus vectores a la altura de la torre
        PunterLaser.y = Torreta.transform.position.y;//______________________________________________________________________________________
        Torreta.transform.LookAt(PunterLaser);
        Quaternion rot = Quaternion.LookRotation(PunterLaser);

        Torreta.transform.rotation = Quaternion.Lerp(Torreta.transform.rotation, rot, 2.0f * Time.deltaTime);
        PunterLaser.y = ObjetivoActual.transform.position.y;//______________________________________________________________________________________
        Quaternion Eleva = Quaternion.LookRotation(PunterLaser);
        Can.transform.rotation = Quaternion.Lerp(Can.transform.rotation, Eleva, 2.0f * Time.deltaTime);
        */




        //___________________________________________________________FUNCIONAA____Metodo 1 de look at restringiendo ejes,

        //ObjetivoActual = ListaEnemigos.BUSCAR EL PRIMERO DE LA LISTA;

       


       //?? Vector3 TargetPos = new Vector3(ObjetivoActual.transform.position.x,   transform.position.y,    ObjetivoActual.transform.position.z);
      

        //Crea un vector 3 que actualiza todo el tiempo como Vector3(Objetivo-x,y-nada,z-Objetivo) 
       //DA IGUAL QUE SEA UN TRANSFORM PUEDE SER UN GAMEOBJECT EL OBJETIVO, ASI PUEDES TOMAS MAS DATOS DE UNA LISTA DE GAMEOBJECTS y sus componentes del objetivo para mostrarlos en hud.



        //Torreta.transform.LookAt( ObjetivoActual );
        // Can.transform.LookAt(ObjetivoActual);
    }
        void OnTriggerEnter(Collider other)
    { 
        switch (other.gameObject.tag)                                           // si la  avariable recibida, es el tag del objeto colisionado es case "nmombre" (no numero)
        {
            case "Enemigo":                                                     //en caso de que el tag sea enemigo
                ListaEnemigos.Add(other.gameObject.GetComponent<Transform>());  //añade el transform del objeto a la lista (para luego poder seguirlo)
                AltavozSensor.clip = BD_AUDIO.Detectado_Enemigo;                //Pone el clip a sonar en este caso
                AltavozSensor.Play();                                           //Lo reproduce

                ObjetivoActual = other.gameObject.GetComponent<Transform>();    //Cambia objetivo haia ese para empezar a mirarle
                break;

            case "Aliado":                                                      //en caso de que el tag sea aliado hace lo mismo pero acediendo a lista y sonido de amigos.
                ListaAmigos.Add(other.gameObject.GetComponent<Transform>());    
                AltavozSensor.clip = BD_AUDIO.Detectado_Aliado; 
                AltavozSensor.Play(); 

                break;
        }
    }
        void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)                                            //Igual que el anterior solo que resta de la lista y reproduce otros sonidos 
        {
            case "Enemigo":
                ListaEnemigos.Remove(other.gameObject.GetComponent<Transform>());
                AltavozSensor.clip = BD_AUDIO.Perdido_Enemigo;
                AltavozSensor.Play();

                //ObjetivoActual = null;
               //Vector3 PunteroLaser = new Vector3(0, 20, 0);

                break;
            case "Aliado":
                ListaAmigos.Remove(other.gameObject.GetComponent<Transform>()); 
                AltavozSensor.clip = BD_AUDIO.Perdido_Aliado;
                AltavozSensor.Play();
             break;
            default:
                Debug.Log("caso default de sensor");
                break;


        }
    }

}
   

//______________________________________________POR MEJORAR______________________________________________


    //Que reciba objetos para poder buscar en esllos el script de entidad y ver el estado de la vida, para hacer un if, y si es enemigo pero esta muerto que no le ataque ni le mire mas.
    // Se queda siguiendo el ultimo enemigo aunque salga, mirar como hacer null sin que retorne error.
    //Velocidad de look at
    //Distancia de deteeccion regulable haciendo escalable la esfera.
    //y si le digo que el objetivo es siempre el primero que detecta mientras no muera(el primero que tiene en la lista)?
    //Y si no quiero que detecte objetivos? dehabilito el sensor-OBJ?