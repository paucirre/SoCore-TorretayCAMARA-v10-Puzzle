using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interac_Manager : MonoBehaviour
{
    public delegate Accion AccionDisponible(GameObject Colision);



   // public Accion DevolverAccionesPosibles(GameObject Colision) {



public Accion AccionActual;
    // public string TagColisionado = GameObject.Compare.tag;  
       }





    /*
     *unidad seleccionada?
     * 
     * 
 __________________________________________________________________________________________________________
 ___________________________________X Relacion_____________________________________________________________
 __________________________________________________________________________________________________________
Switch(Relacion)
   #region Enemigo

	 case-A Relacion.Enemigo
        switch(entidad.tag)
          case-1 Tag.NPC                                
                         public void AgarrarCuello   () { }  //(Por detras)
                         public void Ataquesigiloso   () { } //(Sin verte, por la espalda a menos de 1m)
                         public void DesarmaYReduce () { } //(Sin verte? armado y a menos de 1m)
                         public void HablarEnemigo    () { } //(traje igual que el suyo)"espia"
                         public void Parlamento       () { } //(¿¿¿¿¿¿¿¿¿¿?????????)
                case-1a Tag.NPC && Status.Rendido
                                 public void Esposar()  { }           //(Rendido-Incapacitado)  
                case-1b Tag.NPC && Status.Detenido
                                public void Agarrardetenido () { }  //(Esposado)
                                public void Soltardetenido  () { }  //()
                                public void Liberar         () { }           //(Esposado-prisionero)
                                public void IntroducirDetenido() { }           //(Esposado-prisionero)
                case-1c Tag.NPC && Status.Agarrado
                                public void NokearAgarrado () { }   //(Esposado)
                                public void MatarAgarrado  () { }   //(AgarradoCuello)
                                public void Interrogar     () { }   //(Moribundo, o Agarrado)

            case-2 Tag.VEHICULO 
                         public void Sabotea       () { }   >Sabotear           (Habilidad sabotaje + toolbox) 
                         public void Confiscar     () { }   >RobarGTA           (No lock,o vacio)
                       
            case-3 Tag.ESTRUCTURA
                         >ORDEN___Atacar Estructura (Con unidades seleecionadas)
            case-4 Tag.Puerta
                         >ORDEN__Entrar y despejar (Con unidades seleecionadas) 
#endregion
    __________________________________________________________________________________________________
   #region NeutralCivil

		  case-B Relacion.Neutral/Civil
             switch (Entidad.Tag)
                  case-1 Tag.NPC
                             >Hablar    ????             (inicia sistema de conversacion con opciones disponibles)
                             >Preguntar?
                             >Comerciar?
                             >Reclutar ?
                    
            case-2 Tag.VEHICULO
                             >Mellevas?
            case-3 Tag.ESTRUCTURA

            case-4 Tag.puerta
                    >LlamarPuerta
#endregion
    _________________________________________________________________________________________________
#region Amigo
		
        case-C Relacion.Amigo
            
            case-1 Tag.NPC:
            case-2 Tag.VEHICULO
            case-3 Tag.ESTRUCTURA
#endregion

    __________________________________________________________________________________________________________
__________________________________Por BANDO_______________________________________________________________
__________________________________________________________________________________________________________

#region Bando_Entorno

        Switch (BandoNombre)                            //Switch por nombre de Bando
           caso-A Bando.Entorno                             //Caso-A Bando Entorno                        
                Switch (entity.tipo)                              //Switch tipo   //depende del tipo de objeto de entorno...          
		            case tipo.Entorno
               (if?)case tipo.Recurso
                        Switch (Entity.Subtipo)
                            case Recur_Piedra
                            case Recur_madera     
               (if?)case tipo.Restos
                        Switch (Entity.)
                            case tipo.Restos             >Investigar_Restos         
                            case tipo.RestosVehiculo     >Investigar_Vehiculo)  
                            case tipo.Container          >Investigar_Containers  
                            case tipo.Cadaveres          >Investigar_Cadaveres  >RegistrarCadaveres 
                    case tipo.En_apuros          >Ayudar
    


#endregion
    ________________________________________________________________________________________________

#region Bando_Animal

            case Animal              >DarComida
            case Animal_Muerto       >Recolectar >Investigar
            case Animal_Domesticable >Domesticar   
            case Animal_Montable     >MontarAnimal_
            
    
# endregion___________________________________________________________________________________|
    _______________________________________Genericos_______________________________________________________|
_______________________________________________________________________________________________________|
   
     case VEHICULO              >Drenar >Rellenar       (vehiculo cualquiera + Item Garrafa)
     case5 CONTENEDOR           >Abrir  >IntroducirCargaEnManos >Reabastecerse >GanzuaForzar

_______________________________________________________________________________________________________|
________________________________________Caido__________________________________________________________|
_______________________________________________________________________________________________________|
  case Inhabilitado          >Cargar >Registrar      (cuerpo; Muerto,Inconsciente,Caido,Moribundo) 


_______________________________________________________________________________________________________|
______________________________________tag-Item + Tipo__________________________________________________|
_______________________________________________________________________________________________________|
    case ITEM
        case1 item              >Coger
        case2 item_Equipamiento >Equipar
        case3 item_pesado       >AgarrarObjeto
                                >SoltarObjeto
_______________________________________________________________________________________________________|
________________________________________tag-Interactividad + Tipo______________________________________|
_______________________________________________________________________________________________________|
  #region TAG_INTERACTIVO
        switch (TipoInteractivo)
		  case INTERACTIVO
        case1 Escalera           > Trepar/Soltarse
        case2 Puerta             > Abrir/Cerrar/EntrarDespejar/EntrarFortalecerse/Rebentar/Bloquear/Desbloquear
        case3 PuertaInf          > UsarOptiward
        case2 PuertaCerradura    > Ganzua/Explosivo/Escopetazo
        case4 Codelock           > UsarCodelock-HackCodelock
        case5 Maquina            > On/Of Repostar/Drenar
        case6 Maquina_Snack      > Usar/Salir
        case7 Monitor_Maquina    > Usar/Salir
        ___________________________________________
        case08 Cama         > Dormir
        case09 Wc           > Necesidades
        case10 Ducha        > Ducharse
        case11 Grifo_Agua   > BeberAgua  
        case12 Grifo_Depo   > Drenar

        case13              >
        case14
        case15 Basura > Rebuscar 
#endregion


    _______________________________________________________________________________
_________________________________________________________________________________________
*/

/*
    //__________________INVENTARIO__________________________
    #region Genericos
    public void SoltarItemSelec() { }
    public void Equipar() { } //Arma o ropa/armadura
    public void Desequipar() { }
    public void ConsumirItem() { }
    public void VenderItem() { }

    #endregion 
    #region Armas
    public void DispararArma() { }
    public void RecargarArma() { }
    public void DescargarArma() { }
    public void PonerSilenciador() { }
    public void QuitarSilenciador() { }
    #endregion
    #region Combustible
    public void VerterCombustible() { }
    public void RepostarDeposito() { }
    public void DrenarDeposito() { }
    #endregion
    #region TOOLS
    public void Desguazar() { } //Extraer recursos
    public void Reparar() { }
    public void ReparacionRapida() { }
    #endregion
    //_____________________________________________
    #region Interaccion_VehiculoEstandar
    public void SubirEnPuesto() { }
    public void Subir_Piloto() { }
    public void Subir_Artillero() { }
    public void Subir_Trasero() { }
    public void Engancharse() { }
    public void RepararSeccion() { } 
    #endregion
     //______________________________________________________  
    #region Funciones_En_Vehiculo
    public void CambiarAPuersto() { }  //??
    public void MotorOnOff() { }    //Enter
    public void Salir() { }         //F
    public void Extraccion() { }    //X
    public void LuzOnOff() { }      //L
    public void Claxon() { }        //
    public void Contramedidas() { } //x 
    #endregion
    #region Funciones-En_Vehi_Pro
    public void TorretaAutomaticasOnOff() { }
    public void EngancharCarga() { }
    public void SoltarCarga() { }
    #endregion
    #region Funciones-En_Vehi_Aereo
    public void DespegarAuto() { }
    public void AterrizarAuto() { }
    public void LucesPosicionOnOff() { }

    #endregion
    #region Funciones-En_Vehi_Nave
    public void EscudosOnOff() { } //x
    public void AerofrenosOn() { }
    public void CerrarAbrirBodga() { }
    public void CerrarAbrirHangar() { }
    public void CerrarAbrirBahia() { }
    public void PilotoAutomatico() { }
    public void PiezaOnOff() { }
    public void DiagnosticoRapido() { }
    #endregion
    #region Funciones-En_Vehi_Espaciale
    public void Acoplarse() { }
    public void Desacople() { }
    public void AtraqueEn() { }

    #region Comunicacion_Espacial_Solicitudes
    public void SolicitarAtraque() { }
    public void SolicitarReparaciones() { }
    public void SolicitarReabastecimiento() { }
    //Solicita Equipo descontaminacion
    //Solicita Rescate abordo 
    #endregion

    #region HiperSaltos
    public void HiperVelocidadOnOff() { }
    public void CalcularSaltoA() { }
public void DarSaltoHiperespacio() { }
    #endregion
    #endregion

    //   public void ReposicionarObjeto() { } Pasale el objeto y su nueva posicion (Para subir a vehiculos o centrar en puntos interactivos)
    //   public void HazHijoDe(){} Pasa hijo y padre (Para subirse en vehiculos)










}
*/