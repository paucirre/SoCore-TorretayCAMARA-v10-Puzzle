using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Nueva Entidad", menuName = "Entidad/Item/1_Arma")]
public class itmArma : Item
{
    public int Cadencia;
    public string NombreMunicion;

    [Header("Audios_arma")]
    public AudioClip Son_Disparo;
    public AudioClip Son_Click;
    public AudioClip Son_Recarga;
    public AudioClip Son_Descarga;
    public AudioClip Son_Encasquilla;
    public AudioClip Son_EnsamblaSilen;
    public AudioClip Son_DesmontaSilen;
    public AudioClip Son_Apuntar;

}
