using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUser : Usuario
{

    [Header("Usuario_Juego")]
    public string NombreClave; //se designa en menu de creacion NombrePersonajePrincipal
    public string Mote;
    public AudioListener AL_Player;
    public AudioListener AL_Camara;
    public Mision[] MisionesActivas;




    [Header("Camaras y Canvas")]
    public Camera CamaraActiva;
    public Camera CamaraPrincipal;
    public Camera CamaraRts;
    public Canvas CanvasPlayer;
    public Canvas CanvasRTS;

    public Camera[] CamarasEntrno; //mete aqui las camaras del entorno con las que colisiona si son de tipo ambiental para luego poder cambiar a ellas




}
