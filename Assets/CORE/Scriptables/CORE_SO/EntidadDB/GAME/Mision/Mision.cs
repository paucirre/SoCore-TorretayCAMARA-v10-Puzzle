using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Mision_", menuName = "Etereas/GAME/Mision/Mision")]
public class Mision :ScriptableObject
{
    [Header("Mision")]
    public string NombreMision;
    public enum PrioridadMision { Imprescindible = 0, Opcional = 1, }
    public PrioridadMision prioridadMision;
    public enum Beneficiarios { 
    Tu=0,
    TuEquipo=1,
    TodosLosSubscritos =2,
    }


    public int TiempoMision;
    public Briefing BriefingMision;
    public ObjetivoMision[] ObjetivosDeMision;
         
    public string [] DisponibleEnEscenas;  // escenarios en los que esta disponible
    // CONDICION DE DISPONIBILIDAD igual que condicion? la clase etera?


    public enum CondiccionActivacion { 
    EventoYermo = 0,
    EventoCiudad =1,
    EventoEspacial =2,    }
    //Nombre
    //Briefing desccripcion de inicio
    //Briefing desccripcion de actuacion y objetivos
    //Briefing desccripcion de extraccion
}
