using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//AitorTorresLobato
public class Bando : MonoBehaviour
{
    public int[] CantidadMiembrosTotal;
    public string NombreBando;


    public List <Estructura> Estructuras; //Estructuras primero para luego posicionar posibles NPC
    //public int NumeroEstructuras = Estructuras.Length;
    public List <Vehiculo> Vehiculos;//Vehiculos despues pueden ir en posiciones dentro de estructuras
    //public Props[] Props; //pueden ser items desplegados o mobiliario tal vez?
    //public Item[] ItemsEnEscena;
    public NPC[] NPCs;

    //________________________________________________   o.... ---
    public Entidad[] EntidadesBando; //Mete en una lista todas las entidades del mismo bando para serializarlas y va buscando por tags y creando jerarquia?

    public List<Mision> MisionRuta;



}

//______________________________CONSTRUCTOR DE BANDO________________________________en BANDO MANAGER?
//BUSCA_x_TAG// y que sean del bando X y meteleos en una variable tipo array de GO 
//Por cada uno de la lista guarda sus datos y sus clases internas.como??? y borra el GO
//Hacer 5 veces;

//1---TAG NPC
//2---TAG VEHICULOS
//3---TAG ESTRUCTURAS
//4---TAG PROPS
//5---TAG ITEMS
//_________________

//Cuando termines cierra escena o continua en ella depende si se llama a este metodo al salir o al entrar
