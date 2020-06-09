using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MGcanvas : MonoBehaviour
{
    [Header("_____MENU__CANVAS____")]

    public Canvas Canvas_Escape;
    public Canvas Canvas_TAB;

    [Header("____Sub Menus__Canvas____")]

    public Canvas Canvas_Interactividad;
    public Canvas Canvas_Ordenes;
    public Canvas Canvas_Roseta;

    [Header("____Emergentes____")]

    public Canvas Canvas_Comunicador;
    public Canvas Canvas_Aviso;
         public Text txt_Aviso;
         public Text txt_AvisoBoton_a;//ok si continuar
         public Text txt_AvisoBoton_b;//No cancelar retroceder

    [Header("_____CANVAS____")]

    public Canvas Canvas_Actual;//lo puede cambiar si te pones un casco o gafas de vision nocturna...etc.
    public Canvas Canvas_Unidad;


    public Sprite MirillaDeObjeto;// lo toma del objeto en la mano (prismaticos o arma)


    [Header("_____PANELES o Sub-Canvas____")]
    public Canvas Canvas_Control_Rts;


    [Header("Arma")]
    public Text txt_MuniActual;
    public Text txt_MuniMax;
    public Text txt_MuniTipo;

    [Header("Estado Salud")]
    public Text txt_VidaActual;
    public Text txt_EstaminaActual;
    public Text txt_Hambre;

    [Header("Enemigo u Objetivo")]

    public Text txt_NombreObjetivo;
    public Text txt_VidaObjetivo;
    public Text txt_DistanciaObjetivo;
    public Color color_TxtObjetivo;

    [Header("Enemigo u Objetivo")]

    public Sprite puntero_Generico;
    public Sprite punteroActual_Arma;
    public Color color_Puntero;

    [Header("Conversacion")]
    public Canvas conversacionCanvas;
    public Text txt_Guion;
    public Sprite cameoNpc;


    public Sprite cameoObjInteractividad;








    public Text txtEnemigosDetectados;// deberia cargar todos como stalker






    public Text txtNombreObjetivoActual;
    public Text txtVidaObjetivoActual;
    public Text txtDistanciaObjetivoActual;
    public Text txtNivelArmaObjetivo;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
