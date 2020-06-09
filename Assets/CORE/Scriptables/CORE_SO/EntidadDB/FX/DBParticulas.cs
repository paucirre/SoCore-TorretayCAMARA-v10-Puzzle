using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "BDParticulas", menuName = "DB/DB_Particulas")]
public class DBParticulas : ScriptableObject
{
    public int IntensidadDeParticulasAmb;// Crece si llueve mas
    public int TamañoParticulasImpacto; //  Crecen si el calibre del arma es mas grande
    public Color ColorHumo;

    //prefab puede contener el sonido junto al item junto a las particulas.... 

    [Header("Balistica-Impactos")]
    public ParticleSystem IMP_Generico;
    public ParticleSystem IMP_Agua;
    public ParticleSystem IMP_Carne;
    public ParticleSystem IMP_Bicho;
    public ParticleSystem IMP_Cristal;
    public ParticleSystem IMP_Metal;
    public ParticleSystem IMP_Chapa;
    public ParticleSystem IMP_Madera;

    public ParticleSystem IMP_Bion;
    public ParticleSystem IMP_Mimet;

    public ParticleSystem IMP_BidonComb;
    public ParticleSystem IMP_BidonAgua;
    public ParticleSystem IMP_TuboGas;
    public ParticleSystem IMP_GasVeneno;



    //Las llaman las armas al hacer funcion (explotar) junto con el sonido

    [Header("Explosiones-ObjetosUnicos")]
    public ParticleSystem Explo_Muni_Pistola;
    public ParticleSystem Explo_Muni_Rifles;
    public ParticleSystem Explo_Muni_Explosiva;
    public ParticleSystem Explo_Muni_Electrica;
    public ParticleSystem Explo_Generador;
    public ParticleSystem Explo_Pieza;
    public ParticleSystem Explo_Motor;

    [Header("Explosiones-Granada")]
            public ParticleSystem Exp_Gra_Frag;
            public ParticleSystem Exp_Gra_Case;
            public ParticleSystem Exp_Gra_Humo;
            public ParticleSystem Exp_Gra_IEM;
            public ParticleSystem Exp_Gra_Gas;
            public ParticleSystem Exp_Molotov;
            public ParticleSystem Exp_Gra_Puas;

    [Header("Explosiones-Misiles")]
             public ParticleSystem Exp_Misil;
             public ParticleSystem Exp_Scud;


    [Header("Explosiones-Agua")]
             public ParticleSystem ExplosionPeque;
             public ParticleSystem ExplosionMediana;
             public ParticleSystem ExplosionGrande;
             public ParticleSystem Chorro;

    [Header("Explosiones-Grandes")]

    public ParticleSystem Exp_Artilleria;
    public ParticleSystem Exp_ArtilleriaB;
    public ParticleSystem Exp_Nuclear;
    public ParticleSystem Exp_Bomb_Gran;
    public ParticleSystem Exp_Bomb_Med;
    public ParticleSystem Exp_Bomb_Peq;
    public ParticleSystem Exp_Bomb_Iem;
    public ParticleSystem Exp_Bomb_Gas;

    [Header("Amb-Entorno-Camara")]//instanciado en la camara por el "INTel-Climatologiacontrol"
    public ParticleSystem Amb_Nieve;
    public ParticleSystem Amb_Lluvia;
    public ParticleSystem Amb_LuviaAcida;
    public ParticleSystem Amb_Tierra;
    public ParticleSystem Amb_Polvo;
    public ParticleSystem Amb_PolvoEspacial;

    [Header("Amb")]
    public ParticleSystem Lluvia;
    public ParticleSystem NubesAmb;
    public ParticleSystem Niebla_Nubes;
    public ParticleSystem Rayo;

    [Header("Humos")]
    public ParticleSystem Humo_BL_Peq;
    public ParticleSystem Humo_BL_Med;
    public ParticleSystem Humo_BL_Gran;
    public ParticleSystem Humo_Negro_Grande;

}
