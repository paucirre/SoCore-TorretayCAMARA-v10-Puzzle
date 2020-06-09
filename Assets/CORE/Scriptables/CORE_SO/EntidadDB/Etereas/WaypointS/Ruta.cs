using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruta : MonoBehaviour
{
    public string NombreDeRuta;
    public enum tipoDeRuta {Camino,Mision,Trabajo,Personal}
    public List<GameObject> EntidadesAsociadas;//O ID de unidades?
    public int MaximasPorRuta; //0=sin limite




    public List<Waypoint> ListaWaypoints;



}
