using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntointeractivo : MonoBehaviour
    {
 

    public GameObject ZonaInteractiva; //sera detectada por el propio NPC con su sensor y se dirijira hacia ahi. tomara el nombre de la accion del objeto y si es = a la orden , pues ...
    //Detectando siempre?
    public string NombrePuntoInteractivo;
    [Header("Actores")]
    public GameObject Actor;
    public GameObject Receptor;
    public Animator Actor_Animator;
    public Animator Receptor_Animator;
    public AnimationClip Actor_Animacion;
    public AnimationClip Receptor_Animacion;

    //Coloca al NPC en el Vector 0,0,0 del transform del PuntoInteractivo
    //Pon el estado del animator del NPC en Interactuando = true y pasale el nombre de la animacion
    //Pon el estado del animator del Receptor en Interactuando = true y pasale el nombre de la animacion
}
