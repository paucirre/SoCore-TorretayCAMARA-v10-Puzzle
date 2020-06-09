using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//AitorTorresLobato


[CreateAssetMenu(fileName = "ESCE_", menuName = "ESCENAS/NuevaEscena")]
public class Escena : Entidad {

    //Recogera y pondra los datos obtenidos de las clases guardadas (intel,MarcadoresLista,BandosLista)
    #region TipoEscena
    public enum TipoEscena { Terrestre, Orbital, Espacial }
    public TipoEscena tipoEscena;
    public enum TipoClima { Estable, Tormentoso, Gelido, Arido }  //Tipo clima veranos y tipo de clima inviernos
    public TipoClima tipoClima; 
    #endregion

    [Header("Audios")]
    public AudioEscena Amb_diaNoche;
    public Intel intelEscena;                                         //Guarda clase intel
    public GameObject[] MarcadoresEscena;   //Guarda clae marcadores

    public List<Bando> BandosEnEscena;
    public Bando[] BandosEnEscen;

    // guarda clases unicas como Intel 
    //_____________________________________BUSCA Nº BANDOS en ESCENA__________________________________________________________para utilizarlo de indice en el proceso de serializar datos
    // busca todos los bandos que componen la escena y los mete en un string de Nombres
    //Toma el go y compueba si su equipo esta en la lista sino; agregalo Add.Entity.bando
    //Tras finalizar esta parte tendremos todos los equipos que hay en la escena nombrados en una lista
    //_____________________________________Serializa contenido de BADO____________________________________________________________
    //
    //
    // Busca todos los objetos por tag "" y busca que tenga componente entity y acede a su variable Equipo, si equipo

    public void Start()
    {
      //  LoadEntiti
  //Deberia cargar los objetos en una funcion
    }



    public void RellenarListasEscena ()
    {
        MarcadoresEscena = GameObject.FindGameObjectsWithTag("Marcador");
       // NPC_Escena = GameObject.FindGameObjectsWithTag("NPC");
       // VEHICULOS_Escena = GameObject.FindGameObjectsWithTag("Vehiculo");    
    }
    public void EncontrarListas() 
    {
        //Busca todos los objetos x tag Estructura con script entity.bando==Entorno y los vuelca en lista correspondiente
       // MarcadoresEscena = Object.FindSceneObjectsOfType(Marcador _Marcador);
       //MarcadorAnalizando =

    }

}


public class Conexion: Escena   { 
    public string NombreConexion;    
    public string NombreEscenaConectada;
    public enum TipoConexion {Norte,Sur,Este,Oeste,Superior,Inferior} public TipoConexion tipoConexion; }