using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Briefing_", menuName = "Etereas/GAME/Briefing")]
public class Briefing : ScriptableObject
{
    [Header("Briefing_Mision")]
    public string Descrip_Mision;
    public string Descrip_Intro;
    public string Descrip_Objetivos;
    public string Descrip_Extraccion;
    public string Descrip_OtrasNotas;

    public Sprite FotoMision;
    public Sprite FotoLugar;
  //  public Sprite [] FotosObjetivos = ObjetivoMision
}
