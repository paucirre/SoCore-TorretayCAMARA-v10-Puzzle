using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerMovil : RTSEntidad
{
    public int Velo_Consumo;
    [Header("Velocidades-Tierra")]
    public int Velo_Andar;
    public int Velo_Agachas;
    public int Velo_Tumbado;

    public int Velo_Correr;
    public int Velo_Sprint;
    public int Velo_Herido;
    public int Velo_Caido;

    [Header("Manejo-Tierra")]
    public int Manejabilidad_Terr; //Velocidad a la que gira
    public int Aceleracion_Terr;
    public int Frenada_Terr;
    [Header("Manejo-Agua")]
    public int Velocidad_Acua;
    public int Aceleracion_Acua;
    public int Frenada_Acua;
    [Header("Manejo-Submarino")]
    public int Velocidad_Subm;
    public int Aceleracion_Subm;
    public int Frenada_Subm;
    [Header("Manejo-Aereo")]
    public int Velocidad_Aero;
    public int Aceleracion_Aero;
    public int Frenada_Aeror;
    [Header("Manejo-Espacial")]
    public int Velocidad_Orbital;
    public int Aceleracion_Orbital;
    public int Frenada_Orbital;


}
