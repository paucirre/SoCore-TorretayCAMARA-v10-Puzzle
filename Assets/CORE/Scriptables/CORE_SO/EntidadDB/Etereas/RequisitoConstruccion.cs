using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Requisito", menuName = "Etereas/Reqisito")]
public class RequisitoConstruccion :ScriptableObject
{   public enum TipoRecursoNombre { 
        Alimento=0,
        Madera  =1,
        Piedra  =2,
        Metal   =3,
        Oro     =4,
        Kerium  =5,
        Gas     =6,
        Creditos=7}
  public TipoRecursoNombre tipoRecursoNombre;

    public string Nombr_Itm_Necesario;
    public int CantidadNecesaria;}

