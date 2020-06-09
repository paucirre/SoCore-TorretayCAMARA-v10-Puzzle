using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estadisticas :ScriptableObject
{
    [Header("Historia")]
    public int ProgresoHistoria;
    [Header("Misiones")]
    public int MisionesJugadas;
    public int MisionesGanadas;
    public int MisionesPerdidas;
    [Header("Ataques")]
    public int EnemigosEliminados;
    [Header("Ayudas")]
    public int SupervivientesRescatados;
}
