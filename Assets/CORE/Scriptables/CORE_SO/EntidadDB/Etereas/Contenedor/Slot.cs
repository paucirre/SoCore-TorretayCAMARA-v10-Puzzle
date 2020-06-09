using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//AitorTorresLobato
public class Slot : MonoBehaviour
{
    public Item ItemEnSlot;// id de DB
    public GameObject cameo;

    public int EstadoItem;//lo guarda ya que sera lo unico que cambie in game, cuando se lean los atributos del item
    public string[] TiposDeItemsAdmitidos;//Kit,arma,casco,mask,mochila,Blindaje,
    public string[] SubtipoAdmitido; //

    /*public void UpdateSlot()
    {
        if (ItemEnSlot != null) //Si el slot no esta vacio
        {
            cameo.GetComponent<Entidad>().Cameo = ItemEnSlot.Cameo; //Toma componente entidad.cameo
            cameo.SetActive(true);                                  //Pone la imagen activa
        }
        else    // deactiva El icono cameo
        {
            cameo.SetActive(false);
        }
    }
    */
}