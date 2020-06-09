using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partida : MonoBehaviour
{ 
    public string Escenario;
    //Al cargar la partida busca a mision manager y le pasa los objetivos para que este pendiente de si se cumplen o se fallan y llame a la pantalla correspondiente
    //Cada jugador tiene tb su mision y sus objetivos
    public List<Bando> BandosEnJuego;
    public int TiempoPartida;
    public int FuegoAmigo; // si es = a 0 no se restara por colision
    public int RecursosIniciales;//establece como si fuese PLANETA
    public int CantidadDeAnimales;
    
    public enum TipoRespawn {menuSeleccion,Basico} //Elegir equipamiento y salir, o salir con lo basico en otro sitio para volver a por tu equipo
  
  
}
