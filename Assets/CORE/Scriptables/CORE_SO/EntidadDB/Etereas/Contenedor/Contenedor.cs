using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//AitorTorresLobato
public class Contenedor : Entidad
{
    public enum Actitud {Inventario,Mochila,Caja,Mueble,Maletero,SpawnZone,Bodega};
    public int NombreContenedor;


    public List<Slot> ListaSlots;
    public List <Item> itemList ;                   



    //__________________________FUNCIONES PARA DLL?
    private bool Add(Item _item) //Recibe item devuelve falso si ...
    {
        for (int i = 0; i < itemList.Count; i++) // (Recorre la lista de items)    Inicia indice a 0, Mientras indice de lista de items sea inferior a 0,sube un puesto
        {
            if (itemList[i] == null)            //(Comprueba si la lista esta llena) Si indice es null
            {
                itemList[i] = _item;             //Agrega clase item en posicion i de array

                ListaSlots[i].ItemEnSlot = _item;   //Guarda item en posicion i de Slots Array(Al slot siguiente libre)
                return true;//Fin funcion
            }
                }
        return false; //Sino hay espacio
        }

    }
