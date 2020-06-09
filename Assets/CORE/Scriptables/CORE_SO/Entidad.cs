using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//AitorTorresLobato


[CreateAssetMenu(fileName = "Nueva Entidad", menuName = "Entidad/Global")]

public class Entidad : MonoBehaviour {
    [Header("Entidad")]
    public GameObject Prefab;
    public string Equipo;
    public string Nombre;
    public Sprite CameoPersonal;
    public string Descripcion;
    [Header("Identificacion")]
    public int ID_Unica_Referencia;  //Para desbloqueos en lista de desbloqueos
    public int ID_En_Escena;
    [Header("Posicion")]
    private Vector3 Posicion;
    private Quaternion Rotacion;
    public float[] Pos;
    public float[] Rot;

    [Header("Contenido")]
    public Contenedor Contenedor;

    [Header("Estado")]
    public int VidaIntegridad;
    public int EnergiaCombus; //o.. Alimentacion/Combustible
    public int NivelGeneral;  //o..Energia/Energia
    public int Activo;                          //blindaje o escudos


    public void SalvarPartida()
    {
        if (Input.GetKeyDown("w"))
        {//BuscaBandos en escena
            SaveLoad.SaveEntity_Binary(this);
        }
    }

}

/*Instrucciones Multivariables
   ________________________________________________________VARIABLES MULTIFUNCION______________________________________________________________
||      OBJETIVO: Que las mismas variables sirvan de forma difente en difentes objetos al ser creado y guardado, asi evitamos cargar variables redundantes
||
||                                                                       TIPO DE ENTIDAD                                                                                                                                          
||                NombreVariable                SeresVivos      vehiculos      VehiculosConEscudos       Items/Props      Estructuras     Planeta/Escena     
//public int VidaIntegridad;//                Vida            Integrida       Integridad               Integridad       Integridad      NivelVidaAnimal
//public int EnergiaCombus; //                Energia         Combustible     Combustible              ----------       Energia(SiNo)   NivelTemperaturas
// public int NivelGeneral; //                 NivelXp         Blindaje        Escudos                  ----------       ???????????     NivelOxigeno
//____________________________________________________________________________________________________________________________________________  */


// public GameObject Obj_Roto;        se pone mas abajo en clase vida y ahi comprueba el estado al inicializar y cambia el objeto, no necesita estar aqui
// public GameObject Obj_Destruido;                

















