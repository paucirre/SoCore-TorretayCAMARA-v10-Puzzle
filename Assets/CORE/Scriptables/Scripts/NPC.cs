using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{


    public Voz voz_Personaje;
    //public Apariencia AparienciaPersonaje //Listas de tipos de datos para morphs , colores y pelo o complementos.     














    public bool Alerta;


    public enum EstadoPlayerController {Ensuelo,Saltando,EnVehiculo,Caida,Nadando,buzeando,Trepando};//En vehiculo pos?
    public bool Atacando;

    public enum EstadoActual { Tranquilo,sospecha,Alerta,Busqueda,};
    public enum ActitudActual {Hudiza,Agresiva,Defensiva,Centinela,Inmovil};
    public enum VelocidadActual {caminar,andar,correr,sprint};
    public enum Postura {Pie,Agachado,Tumbado};

    public int Comida;


    
    #region Var_IA
    [Header("IA Control")]
    public bool ReportarEnemigosAEquipo;                                //
    public int Paciencia;            //Tiempo que continua mirando hacia un sitio tras perder de vista al enemigo, "por si no ha muerto y se vuelve a asomar"
    public int TiempoDeReaccion;     //Tiempo que tarde entre apuntar a objetivo y abrir fuego
  //public bool sendFireWarning;     //agregará un icono parpadeante al minimapa al disparar
    public float ScanSpeed;          //Velocidad a la que la escanea el area en busca de enemigos, dependera de la habilidad en general
    public bool checkLineOfFire;     //AI no disparará si un soldado amigo está en su línea de fuego (se puede quitar en momentos "extremos")
    #endregion                                //public int AlcanceRadar;       //Descubre enemigos incluso si no estan a la vista
    #region Var_Personal
    [Header("Personal")]
    public int[] HistoriaPersonal;
    public Relacion[] Relaciones; //clases de relacion y con un nombre y la "cantidad de amistad"  las almacena cada vez que conoce a alguien o hace relacion con otro equipo.
    public int[] EscenasConocidas;
    public int[] CrafteosDisponibles;
    #endregion
    #region Var_Skills
    [Header("SKILLS")]
    public int Vision_Distancia; //incrementa con prismaticos y disminuye con noches niebla o lluvias
    public int Vision_Angulo;   //se reduce con la velocidad?
    public int Fuerza;
    public int Velocidad;
    public int Sigilo;
    #endregion
    #region Var_Habilidades
    [Header("HABILIDADES")]
    public int Niv_Superviviencia;
    public int[] Habilidades_Superviviencia;
    public int Niv_Ingenieria;
    public int[] Habilidades_Ingenieria;
    public int Niv_Pilotaje;
    public int[] Habilidades_Pilotaje;
    public int Niv_Combate;
    public int[] Habilidades_Combate;
    #endregion
    #region Var_Base_Casa
    [Header("Zona de Confort")] // vienen de la propia entidad, con energia o combustible etc...
    public Transform CasaPropia;
    public Transform OcioZonas;
    public string TrabajoPuesto;
    public Transform TrabajoEstructura;
#endregion




    public enum Tipo_Trabajo {Comerciante, Constructor, Recolector, Reparacion, Medico, Ingeniero, Transportista , Seguridad, Bomberos,}
    public enum Segundo_Trabajo {Guia,Escolta,Mercenario,Trapicheo,Informador,Hacker,Asesino }
    public enum Rol_Militar {Superviviente,Infanteria,Sniper,Apoyo,Piloto,Medico,}

}
