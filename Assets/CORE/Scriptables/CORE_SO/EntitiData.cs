using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//AitorTorresLobato

//OBJETIVO:
//Esta clase almacenara los datos que pasaremos al formato de guardado que decidamos
[System.Serializable]
public  class EntitiData
{

    public int ID_En_Escena;
    public string Equipo;
    public string NombrePrefab;
    public string Nombre;
    public string Descripcion;

 

    public bool Activo;
    public bool ControlLock;

    public enum Clase {Personaje,Estructura,Vehiculo,Prop,Item,Bando }
    public enum Actitud {Agresiva,Defensiva,Centinela,Inmovil,Huidizo}
   
    
    public float[] Pos;
    public float[] Rot;

    public string FSM_Estado;

    /* public Vector3 Posicion;
     public Quaternion Rotacion;
 *

    //public Contenedor Contenedor;  //Tomara el contenedor de la entidad
    // public string[] SlotContenedor; //tomara el numero de slots y su contenido en un array ,si no hay pondra vacio
    //public int NumeroSlots;
     public GameObject Obj_Bien;

     */

    public int VidaIntegridad;
    public int EnergiaCombus; 
    public int NivelGeneral;

    public List <Ruta> RutasEntidad;            //Misiones//Trabajos o posiciones
    public List <Item> Items;                   //Inventario//Props//Maletero
    //pubic Piezas[] PiezasComponen//Buscar en PIEZAS dentro de hijos.?




    //CONSTRUCTORRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
    public EntitiData()
    {
        Pos = new float[3];     
        Rot = new float[3];

    }

    public EntitiData(Entidad _entidad) //constructor de entidad //toma un objeto de la
    {
        Nombre = _entidad.Nombre;
        Equipo = _entidad.Equipo;        
        Descripcion =   _entidad.Descripcion;

        //ID_Instancia = _entidad.IDInstancia;
        // Contenedor_entidad.Contenedor;
                              

        VidaIntegridad = _entidad.VidaIntegridad;
        EnergiaCombus  = _entidad.EnergiaCombus;
        NivelGeneral = _entidad.NivelGeneral;


        Pos = new float[3];
        Pos[0]=_entidad.transform.position.x;
        Pos[1]=_entidad.transform.position.y;
        Pos[2]=_entidad.transform.position.z;

        Rot = new float[3];
        Pos[0] = _entidad.transform.rotation.x;
        Pos[1] = _entidad.transform.rotation.y;
        Pos[2] = _entidad.transform.rotation.z;

    }
}

