using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointSO : ScriptableObject
{
    public string nombreWaypoint;
    public GameObject ObjetivoDeWaypoint; //almacena el objeto si no es sobre terreno y sobre un objeto. asi si se mueve el objetivo el waypoint tb (hacerhijo?)
    public bool MostrarIndicadorEnGui; 
    public int RadioActivacion;

    //blic Efectos efectos;

    public enum OrdenAccion {Ir,Entrar,salir,Embarcar,Desembarcar,Usar,Agarrar,Soltar,Destruir,Bombardear,BuscaryDestruir,BuscarUtil,Retirada,Arrestar,Rescatar,}
    public OrdenAccion ordenAccion;

    // [Header("Opcion de cambio al pasar por waypoint")]
     

    public enum Cambio_Actitud { Hudiza, Agresiva, Defensiva, Centinela, Inmovil };
    public Cambio_Actitud cambio_Actitud;
    public enum Cambio_Velocidad { caminar, andar, correr, sprint };
    public Cambio_Velocidad cambio_Velocidad;
    public enum Cambio_Postura { Pie, Agachado, Tumbado };
    public Cambio_Postura cambio_Postura;
}
