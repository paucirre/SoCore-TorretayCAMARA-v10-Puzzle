using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DlllInputManager : MonoBehaviour
{
    //Determina que imput pulsas para poner al personaje en uno u otro estado dependiendo de la condicion en la que se encuentre
    //lamara a gui manager y activara cosas del canvas o movera al personaje
    #region Inputs_Generales
    [Header("GENERALES-Menu")]
    public Input Mapa;
    public Input MisionObjetivos;
    public Input Inventario;
    public Input Escape;

    #endregion
    #region Inputs_Generales
    [Header("GENERALES")]

    public Input VistaCamaraX;  //=RatonX
    public Input VistaCamaraY;  //=RatonY

    public Input CambioCamara;  //V
    public Input RTSMode;       //Enter
    public Input CinematicMode; //Retroceso

    public Input Spritar;       //turbo

    public Input Evasiva_Adelante;  //x2 W
    public Input Evasiva_Atras;     //x2 S
    public Input Evasiva_Izquierda; //x2 A
    public Input Evasiva_Derecha;   //x2 D

    public Input Luz_OnOff; //L 
    #endregion
    #region Inputs_aPie
    [Header("INPUTS_APIE")]

    public Input Interactuar; //F

    public Input GolpearAgarrar;     //BlockMayus

    public Input Andar_Adelante;
    public Input Andar_Atras;
    public Input Andar_Izquierda;
    public Input Andar_Derecha;

    public Input Agachar;   //Control
    public Input Saltar;    //Espacio

    public Input Disparar;           //Raton.1
    public Input Zoom;               //Raton.2.Mantener (animacion zoom camara =on/off)
    public Input Apuntar;            //Raton.2
    public Input Recargar;           //R
    public Input LanzarGranada;      //G
    public Input SoltarObjetoManos;  //J 
    #endregion
    #region Inputs_Combate

    [Header("INPUTS_COMBATE")]

    public Input AgarrarSoltar;
    public Input Nokear;
    public Input Matar;
    public Input Interrogar;
    public Input Desarmar;
    public Input Quieto;

    #endregion
    #region Inputs_Vehiculos
    [Header("INPUTS_VEHICULO")]

    public Input Motor_OnOff;
    public Input LockUnlock;
    public Input Contramedidas;     //X
    public Input Desplegar_OnOff;

    public Input EjecutarAbilidadA;
    public Input EjecutarAbilidadB;

    public Input FrenoMano;
    public Input AutoEstabilizador;
    public Input AutoPiloto; 
    #endregion
    }
