using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Objetivo_", menuName = "Etereas/GAME/Objetivo/Nuevo Objetivo")]
public class ObjetivoMision : Mision
{
    [Header("Objetivos_Mision")]//Asociado a un GAMEOBJECT O A UN WAYPOINTque crea el  mision manager??
    public GameObject[] Objetivos;
    public string NombreObjetivo;
    public int TiempoObjetivo;
    public Sprite FotoObjetivo;
    public GameObject ObjetosTrigger;//Objetos que va a estar analizando a ver si se cumple la condicion
    public enum PrioridadObjetivo
    {
        Imprescindible = 0,
        Opcional = 1,
    }

        public PrioridadObjetivo prioridadObjetivo;


    
}
