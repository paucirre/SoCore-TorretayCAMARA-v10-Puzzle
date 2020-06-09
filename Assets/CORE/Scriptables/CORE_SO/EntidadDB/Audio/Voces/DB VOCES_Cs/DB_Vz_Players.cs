using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BD-Vz-Pla_", menuName = "DB/DB_Voz/DB_Voces_Player")]
public class DB_Vz_Players : ScriptableObject
{
    public VozPersonaje[] VocesDePersonajes; //debe ser un diccionario sino al buscar debo buscar por el puesto en el array no puedo por nombre.

   
}
