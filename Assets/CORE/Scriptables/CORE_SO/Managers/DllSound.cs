using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DllSound : ScriptableObject
{
    //Ricibe nombre de DB de avuido y el indicie(nombre) por el que buscara el array
    public List <DB_Vz_Players> DB_Voces_Personajes_;
    //public Dictionary DB_Dicionario; Toma el diccionario de la DB destino y busca x indicie
    //Declarar las bases de datos a las que va a acceder para extraer el clip que le pedimos
    public AudioClip AudioPedido; // = db.dicionario.nombre

   
   //---------FUN-PRINCIPAL__________ public void LanzarSonido(); { BuscaDiccionarioDB()  BuscarEnDiccionarioDB ()  RandomEnArray () }


    public void BuscaDiccionarioDB() { }
    public void BuscarEnDiccionarioDB() { } //busca en el diccionario el nombre del array de frases
    public void RandomEnLista() { }     //Selecciona una posicion "Random" del array (un sonido) y lo ejecuta

    public void CambiaSonidoDiaNoche() { }     //cambia el sonido de una zona o escena segun la hora (es llamado por Kronos)
}

/*Objetivo:
Buscar en DB diccionario un array por nombre (indice) y volcarlo en una variable para buscar una de sus posiciones random el audioclip y reproducirlo*/
