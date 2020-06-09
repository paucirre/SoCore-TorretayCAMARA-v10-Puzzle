using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion : MonoBehaviour
{
    // Posiciones que contiene un vehiculo un animal montable o un prop
    public enum PosicionTipo {Conductor,Piloto,ArtilleroPrincipal,ArtilleroSecundario,Tripulante,Trasera,Carga};

    public int NombrePosicion;//Para mostrar en GUi
}
