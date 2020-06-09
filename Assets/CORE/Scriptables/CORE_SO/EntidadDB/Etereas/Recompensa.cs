using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Recompensa_", menuName = "Etereas/GAME/Etereas/Recompensa")]
public class Recompensa : ScriptableObject //Recompensa
{
    public int amistad;         //cantidad a sumar o restar
    public string ItemMoney;    //Nombre de item
    public int CantidadItem;
    public int CantidadXp;
    public enum TipoXP { 
    
    XPGeneral= 0,
    Supervivencia=1,
    Ingenieria=2,
    Combate=3,
    Pilotaje=4,    }
    public TipoXP tipoXP;




    public Estructura[] EstructurasDesbloq; //estructuras que desbloquea o añade a lista de disponibles
    public Mision[] MisionesDesbloq;
    public string[] InfoLugares; //nombres de escenas x nsi no las conocias
    //+- Refuerzos
};
