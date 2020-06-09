using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Vehiculo", menuName = "Entidad/Unidad/Vehiculo_General")]
public class Vehiculo : SerMovil
{
    public GameObject[] Torretas;
    public GameObject[] Motor;


    public int VelocidadActual;

    //public (GameObject Persona, GameObject Puesto) SubirConductor(GameObject _Persona, GameObject _Puesto) { return }
    public void SubirArtillero() { }
    public void Bajar() { }
    public void Energia_OnOff() { }
    public void Motor_OnOff() { }
    public void Luz_OnOff() { }
    public void LuzSecundari_OnOff() { }
    public void Acelerar() { }
    public void Frenar() { }





    public void ConsumirCombustible() { }
    public void Reparar() { }


}
