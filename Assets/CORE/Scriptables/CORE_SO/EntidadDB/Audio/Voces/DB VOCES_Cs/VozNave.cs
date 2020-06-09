using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VOZ-Nave", menuName = "Entidad/Voz/Nave")]
public class VozNave : Voz
{
    [Header("Detecciones Sensor")]
    public AudioClip au_DetecEnemigo;
    public AudioClip au_ZonaAsegurada;
    public AudioClip au_AbandonenZona;
    public AudioClip au_ExtremenPrecaucion;
    public AudioClip au_NoHayEnemigosDetectados;

    [Header("Perdida")]
    public AudioClip au_EnemigoEliminado;
    public AudioClip au_EnemigoPerdido;

    [Header("Daños y Reparaciones")]
    public AudioClip au_Integridad;
    public AudioClip au_DetecIncendio;
    public AudioClip au_ReparacionesIniciadas;
    public AudioClip au_ReparacionesFinalizadas;






    [Header("Numeros")]
    public AudioClip au_cien;
    public AudioClip au_cincuenta;
    public AudioClip au_veinty;
    public AudioClip au_diez;
    public AudioClip au_5;

    public AudioClip au_porCien;

    [Header("RIESGO")]
    public AudioClip au_NivelRiesgo;
    public AudioClip au_Bajo;
    public AudioClip au_Medio;
    public AudioClip au_Alto;
    public AudioClip au_Elevado;
    public AudioClip au_Critico;








}
