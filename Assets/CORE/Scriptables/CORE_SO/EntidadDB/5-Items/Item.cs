using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Nueva Entidad", menuName = "Entidad/Item/0_Generico")]
public class Item : RTSEntidad
{
    public int Slots_Ocupa;
    public bool Recolectable;
    public bool AgarrableE;
    public bool Pesado;   //Necesita ser cargado en brazos
    public bool Desplegable;


   

}
