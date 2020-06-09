using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; //necesario para listas??
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
//using System;

public class SensorTorreSuave : MonoBehaviour
{
    #region -----------------VARIABLES----------------
    public int AlcanceSensor;
    private Vector3 SensorXYZ;
    public float PerimetroSeguridad; //si algo se acerca mas lo toma como objetivo automaticamente
    public bool perimetroOn;
    public int Alerta = 0;
    public int compasion;


    public AudioSource Altavoz2;
    public VozNave VozSensor;
    public bool VozSensorOn;

    [Header("[[OBJETIVO]]")]
    public GameObject ObjetivoActual;
    public GameObject ultimoObjetoLista;
    public bool ObjetivoFijado;
    public float DistanciaObjetivo;

    [Header("[[HUD]]")]
    public Text Municiontext;
    public Text IndicadorEnemigos;
    public Text DistanciaObjText;
    public Text ObjetivoActualNombre;

    public DBAudioSensor BD_AUDIO;        // Declara el SO
    private AudioSource AltavozSensor;    //Audiosource que buscara en el padre

    [Header("[[Torreta]]")]
    public Transform Torreta; //para giro
    public Transform Can;     //para elevacion
    public ARMA ArmaPrincipal;

    [Header("Velocidades")]
    public float VelocidadGiro;
    public float VelocidadEleva;
    public float VelocidadElevaLenta;
    public float VelocidadElevaRapida;
    #endregion

    [Header("LISTAS DE OBJETIVOS DETECTADOS")]
    public List<GameObject> ListaEnemigos = new List<GameObject>();
    public List<GameObject> ListaAmigos = new List<GameObject>();
    public List<AudioClip> NarracionVoces = new List<AudioClip>();

    private Vector3 PunteroTorreta;
    private Vector3 PunteroCan;

    private void Start()
    {

        //ArmaPrincipal = this.GameObject.Find("Arma");
       // ArmaPrincipal = this.GetComponentInChildren<ARMA>();
       // AltavozSensor = this.GetComponentInParent<AudioSource>();
       //w Municiontext.text = ArmaPrincipal.MunicionActual.ToString();//_____________________________________________________________________________________________________________________________________________
                                                                    // MuniArmaPrincipal = this.GetComponentInChildren<ARMA>();
                                                                    //----------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> VidaArma.... = this.GetComponentInChildren<ARMA>().MunicionActual.ToString();
    }    //Busca en el padre el componente audiosource en start  
    void OnTriggerEnter(Collider other)
    {
        // Debug.Log("                      Trigger:   Detectado algo por trigger se llama" + other.name);
        ObjetivoActual = other.gameObject;
           DeterminarAlianza(other.gameObject);
        // ObjetivoUltimoLista();
    }
    private void OnTriggerStay(Collider other)
    {
        if (ListaEnemigos.Count > 0) 
        {
            if (ObjetivoActual && ListaEnemigos.Count > 0)
            {
               Debug.Log("                      TRIGGER STAYYYYYYY:  Pasando a apuntado automatico");
               ApuntarObjetivoActual(); 
            }
            else 
           { 
              Debug.Log("                      TRIGGER STAYYYYYYY: No Hay Objetivo principal---Deberia RELAXXXXXXXXXXX"); //RelajarTorreta();  
           }
     
        }
    }

    void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)  
                                       
        {
            case "Enemigo":
               // AltavozSensor.PlayOneShot(BD_AUDIO.Perdido_Enemigo);
                ListaEnemigos.Remove(other.gameObject);
               
                NarracionVoces.Add(BD_AUDIO.Perdido_Enemigo);
                Alerta--;

                if (ListaEnemigos.Count == 0 && !ObjetivoActual)
                {
                    SonarVoz(VozSensor.au_ZonaAsegurada);
                    RelajarTorreta();
                }
                break;
            case "Aliado":
                
               ListaAmigos.Remove(other.gameObject);
                AltavozSensor.clip = BD_AUDIO.Perdido_Aliado;
                NarracionVoces.Add(BD_AUDIO.Perdido_Aliado);
       
                break;

            default:
                
                break;
        }
    }
    
    public void Update()
    {

        Municiontext.text = ArmaPrincipal.MunicionActual.ToString();

        SensorXYZ = new Vector3(AlcanceSensor, AlcanceSensor, AlcanceSensor);      //crea variable vector 3 que tendra en sus 3 variables el tamaño declarado como alcance
        this.transform.localScale = SensorXYZ; //actualiza el alcance/tamaño sensor
   

        if (ListaEnemigos.Count <= 0) { Debug.Log("----------------------------------------SENSOR/   UPDATE dice:        ---------0----------        Enemigos"); ObjetivoActual = null; Alerta = 0; }
        if (ObjetivoActual = null) { Debug.Log("UPDATE dice:                                      No Hay Objetivoo"); }//hacemos que el sensor cambie de tamaño(esto en el futuro se hara mediante una funcion)


        // RecorrerListaObjetos();
        // ObjetivoMasCercano();
        // ApuntarAutomatico();
        //LeerDatosObjetivo();

        if (Input.GetKeyDown("c")) { CambiarObjetivo(); }
       
        if (ObjetivoActual) { Debug.Log("el indice enemigo es: " + ListaEnemigos.FindIndex(d => d == ObjetivoActual) + ". Nombre objetivo: " + ObjetivoActual.name); }

    }

    #region MÉTODOS PRINCIPALES------------------------------

    void SonarVoz(AudioClip _VozRecibida)
    {
        if (VozSensor)
        {
            if (VozSensorOn)
            {
                if (Altavoz2.isPlaying)
                {

                    //StartCoroutine("EsperaAltavozFinalice");                
                    //IEnumerator EsperaAltavozFinalice()
                    //{
                    //    yield return new WaitForSeconds(2);
                    //    //if (!Altavoz2.isPlaying) { StartCoroutine("EsperaAltavozFinalice"); }
                    //    //else
                    //    //{
                    //    //    Altavoz2.PlayOneShot(_VozRecibida);
                    //    //}

                    //}
                    //                Debug.Log("                          VOZ   VOZ   VOZ        esperando para hablar");
                }


                else { Altavoz2.PlayOneShot(_VozRecibida); }
            }

        }
    }
    void DeterminarAlianza(GameObject other)
    {
        Debug.Log("                      Determinar Alianza:   ");
        switch (other.gameObject.tag)
        {
            case "Enemigo":
                Debug.Log("                      Determinar Alianza:  ES ENEMIGO");
              

                if (ListaEnemigos.Count > 0)// hay mas en la lista
                {
                    ListaEnemigos.Add(other.gameObject); Alerta++;
                    Debug.Log("                      Determinar Alianza:  PERO TENGO MAS EN LA LISTA ");


                    //AltavozSensor.PlayOneShot(BD_AUDIO.Detectado_Enemigo);
                    Debug.Log("                      Determinar Alianza: pasandoeste Objetivo principal");
                    ObjetivoActual = other.gameObject ;
                    Debug.Log("                      Determinar Alianza: El objetivo ACTUAL es " + ObjetivoActual.name);
                    Debug.Log("                      Determinar Alianza: pasando comprobando si hay alguno + cerca");
                    ObjetivoMasCercano();
                    SonarVoz(VozSensor.au_DetecEnemigo);

                }
                else
                {   //eres el primero
                    ListaEnemigos.Add(other.gameObject); Alerta++;
                  
                    ObjetivoActual = other.gameObject;
       
                    Debug.Log("                      Determinar Alianza:  ERES EL PRIMER ENEMIGO QUE DETECTO----->" + ObjetivoActual.name);

                    ultimoObjetoLista = other.gameObject;
                    Debug.Log("                      Determinar Alianza:  ERES = Ultimo Objeto de la lista----->" + ObjetivoActual.name);

                }




                break;

            case "Aliado":                                                      //en caso de que el tag sea aliado hace lo mismo pero acediendo a lista y sonido de amigos.
                                                                                //ListaAmigos.Add(other.gameObject.GetComponent<Transform>());    
                ListaAmigos.Add(other.gameObject);
                AltavozSensor.clip = BD_AUDIO.Detectado_Aliado;
                AltavozSensor.Play();

                break;
        }
    }
    void CambiarObjetivo()
    {
        Debug.Log("                     Cambiar objetivo :  5 SEGUNDOS DESPUES....");
        if (ultimoObjetoLista) {
            foreach (GameObject EnemigoInspeccionado in ListaEnemigos)
            {
                if ((ultimoObjetoLista.gameObject) && (ObjetivoActual.transform))
                {
                    if (EnemigoInspeccionado.name != ultimoObjetoLista.transform.name)
                    {
                        Debug.Log( "                            Comprobando nombre de Enemigo Recorrido en lista"+EnemigoInspeccionado.name );
                        Debug.Log("                             Comprobando nombre de Enemigo Recorrido en lista" + ultimoObjetoLista.transform.name);
                        ObjetivoActual = EnemigoInspeccionado.gameObject;
                        Debug.Log(      "                              Enemigo actual es" + EnemigoInspeccionado.name);
                        Debug.Log("                              PASANDO A COMPROBAR LINEA DE FUEGO-ahoramismo");
                        ComprobarLineaFuego();

                        //break;---restaurar
                    }
                }
                //else
                //{
                //    ListaEnemigos.Remove(EnemigoInspeccionado);
                //    Alerta--;
                //}
            }
             
      }
            
        


    


            //int objetivoIndex = ListaEnemigos.FindIndex(d => d == ultimoObjetoLista);


            //Debug.Log("CAMBIAR OBJETIVO. Ahora el indice enemigo es: " + objetivoIndex + ". Nombre objetivo: " + ultimoObjetoLista.name);

            //objetivoIndex--;

            //ultimoObjetoLista = ListaEnemigos[objetivoIndex];

            //Debug.Log("indice= " + objetivoIndex + ".   EL OBJETIVO ACTUAL ES= " + ultimoObjetoLista.name);

            //ObjetivoActual = ultimoObjetoLista.transform;

        }
    void ObjetivoUltimoLista()
        {
        Debug.Log("                    ObjetivoUltimoLista:  Objetivo= ULTIMO DE LISTA:  ");
       
        ultimoObjetoLista = ListaEnemigos.Last<GameObject>();
        ObjetivoActual = ultimoObjetoLista;
     
        Debug.Log("                      ObjetivoUltimoLista:  Pasando a apuntado automatico");
       // ApuntarAutomatico( ultimoObjetoLista);



    }             //Busca:   Datos-ObjetivoXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    void ObjetivoMasCercano()
    {

        float DistanciaAEnemigo;

        Debug.Log("                      Objetivo mas cercano:  ON");
        if (ListaEnemigos.Count > 0)
        {
            Debug.Log("                      Objetivo mas cercano:  Hay enemigos pendientes");
            foreach (GameObject Enemigo in ListaEnemigos)
            {
                Debug.Log("                      por cada enemigo en la lista compara sus nombres");

                DistanciaAEnemigo = Vector3.Distance(Torreta.transform.position, Enemigo.transform.position);

                if (DistanciaAEnemigo < PerimetroSeguridad && DistanciaObjetivo > 0)
                {
                    Debug.Log("                      Objetivo mas cercano:  HA PASADO EL PERIMETRO");
                    ObjetivoActual = Enemigo.gameObject;
                    Debug.Log("                      Objetivo mas cercano:  TOMA ESTE COMO OBJETIVO PRINCIPAL");
                    SonarVoz(VozSensor.au_NivelRiesgo);
                    break;
                }

                else
                {
                    Debug.Log("                      Objetivo mas cercano:  pasando a ultimo objetivo lista");
                    // ListaEnemigos.Remove(Enemigo);Alerta--;

                    ObjetivoUltimoLista();
                }
            }

        }            //recorre: ____Eliminador Nulos_____ // Objetivo El que se encuentre pasado el perimetro de seguridad //Mejorar un poco esto <-
    }
    void ApuntarAutomatico(GameObject _ObjetivoActual)

    {
       //if (ObjetivoActual) {


        Debug.Log("                      APUNTADO AUTOMATICO:  ON");

        Debug.Log("                      APUNTADO AUTOMATICO:  SI hay objetivo calculamos distancia del Obetivo");
        //LeerDatosObjetivo();
        CalcularDistanciaObjetivo();
        VelocidadEleva = VelocidadElevaRapida;
        Debug.Log("                                   APUNTADO AUTOMATICO dice:    apuntando...          ");

        Vector3 PunteroTorreta = new Vector3(
                     _ObjetivoActual.transform.position.x,
                     Torreta.position.y,
                     _ObjetivoActual.transform.position.z);

        Debug.Log("                                   APUNTADO AUTOMATICO dice:    creado vector de Giro...          ");


        Quaternion targetRotaTorre = Quaternion.LookRotation(PunteroTorreta - Torreta.transform.position);         //gira torreta hacia el vector objetivo
        Torreta.transform.rotation = Quaternion.Slerp(Torreta.transform.rotation, targetRotaTorre, VelocidadGiro * Time.deltaTime);
        Debug.Log("                                   APUNTADO AUTOMATICO dice:    creado vector de Elevacion del cañon...          ");
        Vector3 PunteroCan = new Vector3(//crea vector que guiara el cañon
                    _ObjetivoActual.transform.position.x,
                    _ObjetivoActual.transform.position.y,
                    _ObjetivoActual.transform.position.z);

        Quaternion targetRotaCan = Quaternion.LookRotation(PunteroCan - Can.transform.position);                  //gira y eleva Cañon hacia el vector objetivo
        Can.transform.rotation = Quaternion.Slerp(Can.transform.rotation, targetRotaCan, VelocidadEleva * Time.deltaTime);
        Debug.Log("                      APUNTADO AUTOMATICO:  ---ROTANDO TORRETA---");
        Debug.Log("                      APUNTADO AUTOMATICO:  Pasando a comprobar linea fuego");

        ComprobarLineaFuego();
            //if (targetRotaTorre) { };
    //}
    //   else { Debug.Log("        Comprobar linea de fuego:        No hay enemigo"); }
        
      
        
    }
    void ApuntarObjetivoActual()

    {
        //if (ObjetivoActual) {


        Debug.Log("                      APUNTADO AUTOMATICO:  ON");

        Debug.Log("                      APUNTADO AUTOMATICO:  SI hay objetivo calculamos distancia del Obetivo");
        //LeerDatosObjetivo();
        CalcularDistanciaObjetivo();
        VelocidadEleva = VelocidadElevaRapida;
        Debug.Log("                                   APUNTADO AUTOMATICO dice:    apuntando...          ");

        Vector3 PunteroTorreta = new Vector3(
                     ObjetivoActual.transform.position.x,
                     Torreta.position.y,
                     ObjetivoActual.transform.position.z);

        Debug.Log("                                   APUNTADO AUTOMATICO dice:    creado vector de Giro...          ");


        Quaternion targetRotaTorre = Quaternion.LookRotation(PunteroTorreta - Torreta.transform.position);         //gira torreta hacia el vector objetivo
        Torreta.transform.rotation = Quaternion.Slerp(Torreta.transform.rotation, targetRotaTorre, VelocidadGiro * Time.deltaTime);
        Debug.Log("                                   APUNTADO AUTOMATICO dice:    creado vector de Elevacion del cañon...          ");
        Vector3 PunteroCan = new Vector3(//crea vector que guiara el cañon
                    ObjetivoActual.transform.position.x,
                    ObjetivoActual.transform.position.y,
                    ObjetivoActual.transform.position.z);

        Quaternion targetRotaCan = Quaternion.LookRotation(PunteroCan - Can.transform.position);                  //gira y eleva Cañon hacia el vector objetivo
        Can.transform.rotation = Quaternion.Slerp(Can.transform.rotation, targetRotaCan, VelocidadEleva * Time.deltaTime);
        Debug.Log("                      APUNTADO AUTOMATICO:  ---ROTANDO TORRETA---");
        Debug.Log("                      APUNTADO AUTOMATICO:  Pasando a comprobar linea fuego");

        ComprobarLineaFuego();
        //if (targetRotaTorre) { };
        //}
        //   else { Debug.Log("        Comprobar linea de fuego:        No hay enemigo"); }



    }
    void ComprobarLineaFuego()
    {
        Debug.Log("                      ComprobarLineaFuego:  ON      el objetivo actual es" + ObjetivoActual.name);
        for (int i= 0; ListaEnemigos.Count>0; i++)
        {
            Debug.Log("               Comprobar LINEA FUEGO :  FOR ON  ()");
            if (ObjetivoActual.transform.name == ArmaPrincipal.ObjetivoApuntado.name)
            {
                Debug.Log("               Comprobar si esto se llama igual que el objetivo");
                ObjetivoFijado = true;
                ComprobarVida();

            }
            else
            {
                ObjetivoFijado = false;
                Debug.Log("                      ComprobarLineaFuego:  ON      el objetivo actual es" + ObjetivoActual.name);
            }

        }
    }
    //    Debug.Log("                     ComprobarLineaFuego :  ON");
        //    if (ArmaPrincipal)
        //    {
        //        Debug.Log("                     ArmaPrincipal  :  tengo arma principal");
        //        if (ArmaPrincipal)
        //        {
        //            Debug.Log("                     ComprobarLineaFuego :  tengo arma");
        //            if (ARMA.enemigoOculto == true)

        //            { Debug.Log("                     ComprobarLineaFuego :  tengo arma");
        //                if (ListaEnemigos.Count > 0)
        //                {
        //                    Debug.Log("                     ComprobarLineaFuego :  Objetivo fuera de alcance esperando 3 segundos a localizar al siguiente");

        //                    Invoke("CambiarObjetivo", 3);

        //                    // Debug.Log("                     ComprobarLineaFuego :  Objetivo Ocuto pasando a CAMBIAR OBJETIVO por que hay mas en la lista"); 
        //                }
        //            }


        //            else if (ObjetivoActual.transform.name == ArmaPrincipal.ObjetivoApuntado.name)
        //            {
        //                Debug.Log("                     ComprobarLineaFuego :  Entrando en comprobar vida");
        //                ComprobarVida();
        //            }
        //        }
        //        else { Debug.Log("                                                         NO vOY ARMADOOO  No se que hacer BugBugBug...??"); }
        //    }
        //    else { Debug.Log("                     ComprobarLineaFuego :  Arma no hay"); }
    void ComprobarLineaVision()

    {
        Debug.Log("                     ComprobarLinea VISION :  ON");
        Vector3 DireccionEnemigo = new Vector3(

           this.transform.position.x - ObjetivoActual.transform.position.x,
           this.transform.position.y - ObjetivoActual.transform.position.y,
           this.transform.position.z - ObjetivoActual.transform.position.z);

        RaycastHit RayVision;
       

        // AQUI PUEDE COMPROBAR SI ESTA DENTRO DEL RANGO DE VISION SEGU EL ANGULO EN EL QUE ESTE O SABER EN QUE DIRECCION
        // SISTEMA DE HABLA
        //HACIA EL NORTE-HACIA EL SUR ,HACIA EL ESTE,HACIA EL OESTE.....
        Transform posicionENEMIGO = ObjetivoActual.transform;
        if (Physics.Raycast(this.transform.position, posicionENEMIGO.TransformDirection(DireccionEnemigo), out RayVision, AlcanceSensor))
        {
            Debug.Log("                                   VISTA:  el Objetivo a la vista se llama ....."+ RayVision.transform.name);
            if (RayVision.transform.tag == "Enemigo")
            {
                Debug.Log("                                           ENEMIGO A VISTO!!!!");
                //Debug.DrawRay(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), Color.red, AlcanceDeteccionArma);
                //enemigoOculto = false;

            }
            else { 

                //enemigoOculto = true;
            
            }
           
           
          //  if (RayVision.transform.tag == "Amigo") { Debug.DrawRay(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), Color.blue, AlcanceDeteccionArma); }
        }
    }
    public void RelajarTorreta()
            {
        Vector3 Relax = new Vector3(0, 0, 0);
                                                         Debug.Log("RELAXXXXXXXXXXXXX Relajando torreta...........................z..zzzzZzZzZzZzZZZZZZZZZZZZZZZ");
        Debug.Log("                                   APUNTADO AUTOMATICO dice:    relajando torreta...          ");


        Quaternion targetRotaTorre = Quaternion.LookRotation(Relax - Torreta.transform.position);         //gira torreta hacia el vector objetivo
        Torreta.transform.rotation = Quaternion.Slerp(Torreta.transform.rotation, targetRotaTorre, VelocidadElevaLenta * Time.deltaTime);
        Debug.Log("                                   APUNTADO AUTOMATICO dice:    relajando cañon...          ");
   
        Quaternion targetRotaCan = Quaternion.LookRotation(Relax - Can.transform.position);                  //gira y eleva Cañon hacia el vector objetivo
        Can.transform.rotation = Quaternion.Slerp(Can.transform.rotation, targetRotaCan, VelocidadElevaLenta * Time.deltaTime);







        // VelocidadEleva = VelocidadElevaLenta;
        //// Can.transform.rotation = new Quaternion(0, 0, 0, 0);
        //   // Quaternion  PunteroTorreta = new Quaternion(0,0,0,0); Debug.Log("RELAXXXXXXXXXXXXX Relajando torreta...........................creado vector 0");
        // Can.transform.rotation = Quaternion.Slerp(Can.transform.rotation, PunteroTorreta, VelocidadElevaLenta * Time.deltaTime);
        //                                                 Debug.Log("RELAXXXXXXXXXXXXX Relajando torreta...........................cañon Relax");
        // // Torreta.transform.rotation = new Quaternion(0, 0, 0, 0);
        // Torreta.transform.rotation = Quaternion.Slerp(Can.transform.rotation, Can.transform.rotation, VelocidadElevaLenta * Time.deltaTime);
        // Torreta.transform.rotation = Quaternion.Slerp(Torreta.transform.rotation, PunteroTorreta, VelocidadElevaLenta * Time.deltaTime);
        //                                                      Debug.Log("RELAXXXXXXXXXXXXX Relajando torreta...........................Torreta Relax");
    }    
    public void ComprobarVida()
    {
        Debug.Log("                     ComprobarVida :  ON");
        if (ObjetivoActual)
        {

            if (ObjetivoActual.GetComponent<Salud>().Vida > compasion)
            {
                ArmaPrincipal.DISPARA(); Debug.Log("                     ComprobarVida : llamando a: Dispara de arma");
                
            }
            else {
                Debug.Log("                     ComprobarVida :  tenemos compasón por el pobre enemigo");
               // ListaEnemigos.Remove(ObjetivoActual.gameObject);----restaurar
                Debug.Log("                     ComprobarVida :  Dejo de tener como amenaza a El OBjetiVO PRincipal");
                Alerta--;
                CambiarObjetivo();
            }
        }
    }
    void CalcularDistanciaObjetivo()
    {
        if (ObjetivoActual != null)
        { //si hay objetivo
          //Debug.Log("calculando distancia del objetivo");
            DistanciaObjetivo = Vector3.Distance(Torreta.transform.position, ObjetivoActual.transform.position);
            // DistanciaObjText = DistanciaObjetivo.ToString; 
            //  Debug.Log("el objetivo esta a... " + DistanciaObjetivo + "metros");
        }

        //pasar la distancia del objetivo actual a pantalla de interfaz (util para misiones y para juegos de aviones)
        else { DistanciaObjetivo = 0.0f; }
    }

    

    #region FUNCCIONES- HABLAR DECIR Y LEER DATOS, ESTO POSTERIORMENTE VA EN EL SISTEMA DE VOZ Y EN EL INTERFAZ CONTROLLER

    void Decir(AudioClip _PalabraRecibida)
    {

        NarracionVoces.Add(_PalabraRecibida);


        while (NarracionVoces.Count > 0 && !Altavoz2.isPlaying)
        {

            Altavoz2.PlayOneShot(NarracionVoces.First());
            NarracionVoces.Remove(NarracionVoces.First());



        }


    }
    void LeerDatosObjetivo()
    {
        if (ObjetivoActual)
        {

            IndicadorEnemigos.text = ListaEnemigos.Count.ToString();

            ObjetivoActualNombre.text = ObjetivoActual.name.ToString();
            DistanciaObjText.text = DistanciaObjetivo.ToString();



        }
        else { ObjetivoActualNombre.text = "------"; }
    }           //Lee:     Datos-Objetivo
    void VozDecir_IntegridadPropia()
    {
        float VidaSensor = this.GetComponent<Salud>().Vida;
        switch (VidaSensor)
        {
            case 100: SonarVoz(VozSensor.au_cien); break;
            case 50: SonarVoz(VozSensor.au_cincuenta); break;
            case 25: SonarVoz(VozSensor.au_veinty); break;
            case 5: SonarVoz(VozSensor.au_Critico); break;
            case 3: SonarVoz(VozSensor.au_AbandonenZona); break;

            default: break;

        }




        #region _____FUNCIONES SIN USO___________________
        void DescansarCan()
        {

            VelocidadEleva = 0.5f;
            Vector3 PunteroTorreta = new Vector3(0, Torreta.position.y, 0);
            Vector3 PunteroCan = new Vector3(0, 0, 0);
            Quaternion Relaja = new Quaternion(0, 0, 0, 0);

            Quaternion targetRotaCan = Quaternion.LookRotation(PunteroCan);                  //gira y eleva Cañon hacia el vector objetivo
            Can.transform.rotation = Quaternion.Slerp(Can.transform.rotation, Relaja, VelocidadElevaLenta * Time.deltaTime);
            Quaternion targetRotaTorre = Quaternion.LookRotation(PunteroTorreta - Torreta.transform.position);         //gira torreta hacia el vector objetivo
            Torreta.transform.rotation = Quaternion.Slerp(Torreta.transform.rotation, Relaja, VelocidadElevaLenta * Time.deltaTime);
        }
        /*void DescansarCanMeca()
            {
                Vector3 PunteroTorreta = new Vector3(0, Torreta.position.y, 0);
                Vector3 PunteroCan = new Vector3(0, 0, 0);
                Quaternion targetRotaCan = Quaternion.LookRotation(PunteroCan );                  //gira y eleva Cañon hacia el vector objetivo
                Can.transform.rotation = Quaternion.Slerp(Can.transform.rotation, targetRotaCan, VelocidadEleva * Time.deltaTime);
                Quaternion targetRotaTorre = Quaternion.LookRotation(PunteroTorreta);         //gira torreta hacia el vector objetivo
                Torreta.transform.rotation = Quaternion.Slerp(Torreta.transform.rotation, targetRotaTorre, VelocidadGiro * Time.deltaTime);
            */


        void RecorrerListaIndice()
        {
            for (int contador = 0; contador < ListaEnemigos.Count; contador++)
            {
                Debug.Log("Hay" + ListaEnemigos[contador] + "Enemigos detectados"); //pasar esta variable a un txt de la interfaz/miniradar

                if (contador == 0 && ListaEnemigos.Count > 0) { Debug.Log("Eres el Primer y unico Enemigo en la zona!"); }
            }



        }    //Sube y baja puestos de la lista (para seleccionar diferentes objetivos)
        void ObjetivoPrimeroLista()
        {
            ultimoObjetoLista = ListaEnemigos.First<GameObject>();
            ObjetivoActual = ultimoObjetoLista;

            foreach (GameObject Enemigo in ListaEnemigos)
            {
                Debug.Log(ListaEnemigos.IndexOf(Enemigo));// muestra la posicion del enemigo en la lista

            }
        }
        void PosicionEnLista()
        {
            Debug.Log(ListaEnemigos.IndexOf(gameObject));
        }       // muestra la posicion del gameobject en la lista
        void ComprobarObjetivo() { }//compueba que esta vivo, y mas cosas como...si es enemigo o no...y reemplazar tag, o de que tipo es...etc
        void ComprobarLineaDeteccion()
        {
            //lo he descomentado del awake para meterlo aqui, activar el otro tb

            RaycastHit RayCheckObjetivo;
            if (Physics.Raycast(Torreta.position, Torreta.TransformDirection(Vector3.forward), out RayCheckObjetivo, AlcanceSensor))
            {
                if (RayCheckObjetivo.transform.name == ObjetivoActual.name)// si se llama igual que el ultimo objetivo
                {           //Debug.DrawRay(Bocacha.position, Bocacha.TransformDirection(Vector3.forward), Color.red, AlcanceDeteccionArma);
                            // UltimoObjetivoTocado.name = RayCheckObjetivo.transform.name;
                            // ArmaPrincipal.LaserFlashOn();
                            // ArmaPrincipal.DISPARA();
                            //DISPARA();
                }
                else { Debug.Log("HAY ALGO EN MEDIOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO NO PUEDO DISPARARRRRRRRRRR O NO TE VEOOO Y NO TE METO EN LA LISTAAAA Y SI TE VEO MUY CERCA ME DAS UN SUSTOOO"); }
            }
        }
        #endregion
    }
    void VozLeerEstadoAlerta() { }
    void VozLeerNivelRiesgo() { }
    void VozLeerDistandiaObjetivo() { } 
    #endregion
}
//void RecorrerListaObjetos()
//{
//    foreach (GameObject Enemigo in ListaEnemigos)
//    {
//        if ((perimetroOn) && (DistanciaObjetivo < PerimetroSeguridad))
//        {
//            ObjetivoActual = Enemigo.transform;
//        }
//        else { ObjetivoUltimoLista(Enemigo); }
//    }
//    //{
//    //    if (Enemigo) {      }
//    //    else { ListaEnemigos.Remove(Enemigo); }
//    //}

//    //else    {    ObjetivoUltimoLista();   }

//    //recorre: ____Eliminador Nulos_____ //comprobador de Distancia mas cercano?


//}
#endregion
