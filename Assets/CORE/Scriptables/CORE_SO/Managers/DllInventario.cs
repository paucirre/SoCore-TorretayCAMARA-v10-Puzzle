using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DllInventario 
{
    public void BuscaSlotVacio(Contenedor _contenedor) { } //Recibe: Contenedor a buscar en su lista de slots o diccionario?
    public void ComprobarSiCabe(Contenedor _contenedor) { }//Compueba si el tamaño del item es superior al numero de slots vacios
    public void BuscaObjeto(Item _Item,Contenedor _contenedor) { }
    public void IntroducirContenedor (Item _Item,Contenedor _Contenedor){}       //Recibe item y contenedor a añadir y lo hace(no devuelve nada)
    public void RestarContenedor(Item nombre, Contenedor _Contenedor) { }
    
   /*if (myList[2] is Camera) //comprueba que el objeto de la lista sea de un tipo concreto
{
    // Emitir la referencia usando el nombre de la clase entre paréntesis
    Camera c = (Camera)myList[2];
}*/
}
