using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DllMision : ScriptableObject
{
    // Start is called before the first frame update
    public void LeerMisionesDisponibles() {   }
    public void AceptarMision() { }
    public void RechazarMisions() { }
    public void CancelarMision() { }

    public void ActualizaEstadoObjetivos() { }
    public void PierdeMision() { }
    public void GanaMision() { }//agrega recompensa de objetivos y de mision a historial de los que estaban participando

    public void NuevaMisionDisponible() { }//evento que muestra el texto de la mision y la imagen en pantalla y permite aceptarla o rechazarla.
    public void LanzarMisionAuto() { }  //leera las circunstancias y creara una nueva mision disponible
}
