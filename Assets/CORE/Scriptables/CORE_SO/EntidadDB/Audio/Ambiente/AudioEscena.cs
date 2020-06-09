using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEscena : ScriptableObject
{
    public string Audionombretes;//borrar
    [Header("Sonidos Diarios")]
    public AudioClip[] Amb_Madrugada;
    public AudioClip[] Amb_Dia;
    public AudioClip[] Amb_Tarde;
    public AudioClip[] Amb_Noche;
    public AudioClip[] Amb_Lluvia;
    [Header("Subatmos")]
    public AudioClip[] SubAtmos_Noche;
    public AudioClip[] SubAtmos_Dia;
    public AudioClip[] SubAtmos_Tarde;
    public AudioClip[] SubAtmos_Madrugada;

    [Header("Llegadas")]
    public AudioClip EntradaDiurna;
    public AudioClip EntradaNocturna;
    public AudioClip EntradaEnCombate;
    
}

