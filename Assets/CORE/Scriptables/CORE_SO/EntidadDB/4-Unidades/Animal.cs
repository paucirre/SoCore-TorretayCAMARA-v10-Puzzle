using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ("Animal"), menuName = "Entidad/Unidad/Animal")]
public class Animal : SerMovil
{
    [SerializeField]
   
    public enum HorarioDormir {Amanecer,Dia,Tarde,Noche }
    public enum HorarioComer { Amanecer, Dia, Tarde, Noche }

    public enum Alimentacion { Vegetariana, Carnivora, Carronera, Omnivora, Mineral }
    public Alimentacion alimentacion;
    [Header("Animnal")]
    public bool Domesticable; //Reclutable //Se`puede hacer de tu equipo para recibir ordenes?
    public int ResistenciaDomesticacion; //Resistencia a arresto es = a (vida + agresividad - huidizo)
    public bool Montable; //puedes subir encima como un vehiculo?
    public bool ControlablePlayer; //lo puedes controlar como un vehiculo o player en 1º?
    public bool Huidizo;

    public int NivelAgresividad;


}
