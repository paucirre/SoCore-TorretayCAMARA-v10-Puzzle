using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Actitud", menuName = "Etereas/IA/Actitud")]
public class Actitud : ScriptableObject
{

    public enum Nombre_Actitud { 
    
    Huidiza=0,  //evita conflictos si detecta impacto o amenaza
    Agresiva=1, //MOV LIBRE---Persigue enemigo
    Defensora=2,//MOV Limitado--Persigue poco y vuelve
    Vigilante=3,//No mueve pero ataca a distncia si es posible
    Impasiva=4,//No devuelve el fuego ni se mueve a no ser que corra peligro
    }
    public Nombre_Actitud nombre_Actitud;
}
