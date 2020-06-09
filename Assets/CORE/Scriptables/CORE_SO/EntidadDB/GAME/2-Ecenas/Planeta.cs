using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Planet_", menuName = "ESCENAS/NuevoPlaneta")]
public class Planeta : Escena
{
    public enum EstadoEstrategico { 

        Pacifico            = 0,
        GuerraInterna       = 1,
        BajoInvasion        = 2,

    }
    public EstadoEstrategico estadoEstrategico;
}
