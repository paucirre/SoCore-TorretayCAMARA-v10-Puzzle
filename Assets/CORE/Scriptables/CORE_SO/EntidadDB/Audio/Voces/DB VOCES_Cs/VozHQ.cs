using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VOZ-HQ_", menuName = "Entidad/Voz/HQ-Base")]
public class VozBase : Voz
{
    [Header("Detectados_Entidades")]
    public AudioClip Detec_BaseEnemiga;
    public AudioClip Detec_SuperAma;
    public AudioClip Detec_UnidadesEnemig;
    public AudioClip Detec_RefuerzosEnemig;
    public AudioClip Detec_Supervivientes;
    public AudioClip Detec_RestosAccudebte;
    [Header("Detectados_Ataque_a")]
    public AudioClip Detec_AtaqueBase;
    public AudioClip Detec_AtaqueCosechador;
    public AudioClip Detec_AtaqueConstructor;
    public AudioClip Detec_AtaqueCiviles;
    [Header("Detectados_Eventos")]
    public AudioClip Detec_TormentaCercana;
    public AudioClip Detec_CapsulasPods;
    public AudioClip Detec_OleadaLLegando;
    [Header("Informe_Status_Base")]
    public AudioClip EnergiaBaja;
    public AudioClip RecursosInsuf;
    public AudioClip ConstruccionFinaliza;
    public AudioClip EnConstruccion;
    public AudioClip NuevasOpcionesConstrucc;

    [Header("Numeros")]  // Hora // Direccion // Cantidad Enemigos/Supervivientes

    public AudioClip doce;
    public AudioClip once;
    public AudioClip diez;
    public AudioClip nueve;
    public AudioClip ocho;
    public AudioClip siete;
    public AudioClip seis;
    public AudioClip cinco;
    public AudioClip cuatro;
    public AudioClip tres;
    public AudioClip dos;
    public AudioClip uno;
    public AudioClip cero;

    [Header("Auxiliares")]

    public AudioClip Aux_Minutos;   //Minutos
    public AudioClip Aux_Enpunto; //10 enemigos a las 6 en punto! //Son las 2 en punto
    public AudioClip Aux_Ymedia;
    public AudioClip Aux_Pasadas;
    public AudioClip Aux_Quedan_;   //Quedan//Aun quedan//Deben quedar//creo haber contado unos..//Hay mas de...
    [Header("Nombres_de_")]
    public AudioClip NombrEnemigos; //Enemigos
    public AudioClip NombrBichos; //Enemigos
    public AudioClip NombrSupervivientes; //Enemigos
    public AudioClip NombrCiviles; //Enemigos
    public AudioClip NombrENEMIGOS; //ENEMIGOSS A las

}  