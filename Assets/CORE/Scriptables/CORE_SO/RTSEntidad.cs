using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSEntidad : Entidad
{



    //OBJ BIEN
    //OBJ ROTO
    //OBJ DESTRUIDO

    //--------------Variables de faccion----------------
    //Faccion
    //Color-A
    //Color-B
    //Color-C
    //LogoPersonal


    [Header("RTS_Fabricacion-------------------------------------")]
    //--------------Variables de Unidad----------------
    public int PrecioCompra;
    public int PrecioVenta;
    public bool Es_Terrestre, Es_Subterraneo, Es_Acuatico, Es_Subacuatico, Es_Aereo, Es_Orbital, Es_Espacial, Es_Nebular;
    //Cameo
    //imagen
    //Tiempo
    public string[] EntidadesRequeridas; //Estructuras
    public string[] EntidadesDesbloqueadas;//Estructuras//Unidades // i+D
    public RequisitoConstruccion[] requisitosConstruccion;
    //Controlable
    //Reclutable
}
