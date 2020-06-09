using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//AitorTorresLobato

[System.Serializable]
public class EscenaContenedor
{
    
    public Intel intelEscena;                                         //Guarda clase intel
   // public List<Marcador> MarcadoresEscena = new List<Marcador>();   //Guarda clae marcadores    
   //public List<Bando> BandosEnEscena;                               //Guarda Bandos tomados de la escena
    public Bando[] BandosEnEscen;                                                                //public List<Estructura> EstructurasEnEscena = new List<Estructura>();
                                                          //public List<Vehiculo> VehiculosEnEscena = new List<Vehiculo>();
                                                                     //public List<NPC> NPCEnEscena = new List<NPC>();


    //public EscenaContenedor(Intel _intel) { }  //_____CONSTRUCTORRRRRR______ESCENA CARGADA___iguala los datos de la escena tomada a los datos obtenidos___Recibe un contenedor de escena 




    /* CONSTRUCTOR ESCENA
     * _recibe/Envia tras llamada de clase Escena-e iguala las variables-todas las listas de bandos y de clases que la componen*/

   // public EscenaContenedor Bando_Constructor (Bando _Bando)
     //   { return EscenaContenedor;   }

}
    //MISIONES?________

    //public List <Waypoints> WaypointsEscena = new List<>(Waypoints);    
    //public List <Sensor> SensoresEscena = new List<>(Sensor);
    /* public Bando = ;
//__________________________________________________________________________________________________________________________
                //______Busca los objetos por tag (x) en caso de intel/Zonas/Triggers
                //______(y por Entidad.equipo == tuyo) para marcadores y Bando (tb tag ?)
//1º--Toma intel ya que solo hay uno y serializa los datos de esa clase, cierra ese "objeto"

//2º-- Para Marcadores(/Triggers/Zonas) :
            //Por cada marcador en Marcadores  guarda marcador.Entidad? o marcadorDatos
        //Pasa a Guardar (Triggers) nºmarcadores=
            //por cada trigger...in..trigger
        //pasa a Guardar (Zonas) nºzonas=
            //por cada zona in Zonas

//3º-- Para guardar bandos;

        //Por cada bando en lista bandos
                //Guarda datos bando
                    //________________________¿?
                        //_lee nº Estructuras que tiene
                            //por cada Estructura en estructuras
                                    //Save entidadData--------------------------------Mismo esquema de guardado, mismos datos
                            //por cada vehiculo en vehiculos
                                    //Save entidadData--------------------------------SD
                                            //Save Contenedores__________________SC
                                            //Save waypoints................SW
                                            //
                            //por cada NPC en NPC
                                    //Save entidadData-------------------------------SD
                                            //Save Contenedores__________________SC
                                            //Save waypoints................SW
                            //por cada Prop en Props
                                    //Save entidadData-------------------------------SD
                                            //Save Contenedores   ________________SC                                    
                            //por cada Item en items
                                    //Save entidadData-------------------------------SD
                                             //Save Contenedores  ________________SC
           //Cierra archivo guardado






   
   // public Leer cantidad de vehiculos por equipo     public int NumeroEstructuras = Estructuras.Length;
   //ESTABLECER VARIABLES DE NºEQUIPOS EN ESCENA NºVehiculos por equipo y contenedor
//SET
//GET*/