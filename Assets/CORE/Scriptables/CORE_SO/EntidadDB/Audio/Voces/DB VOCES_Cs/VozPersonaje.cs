using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "VOZ-Personaje", menuName = "Entidad/Voz/Player")]
public class VozPersonaje : Voz
{
    //public new enum tipoVoz { Personaje, Base, Nave, Narrador };  


    [Header("DETECCION")]
    //--DETECCION-SOSPECHA
    public AudioClip[] SOSP_Ruido;      //Has oido eso
    public AudioClip[] SOSP_Disparo;    //De donde vienen esos disparos
    public AudioClip[] SOSP_Visto;      //Me ha parecido ver algo
    public AudioClip[] SOSP_Huellas;    //Y estas huellas?
    public AudioClip[] PuertaBloq;      //Parece que esta atrancada

    public AudioClip[] DETEC_Cadaver;    //pero que es esto?
    public AudioClip[] DETEC_Cajamagica; //Encuentra

    [Header("LOCALIZADO")]
    public AudioClip[] DETEC_Enemigo;
    public AudioClip[] DETEC_Granada;
    public AudioClip[] DETEC_EnemiBicho;
    [Header("DAÑOS")]
    public AudioClip[] Quejidos;
    public AudioClip[] Esfuerzo;
    public AudioClip[] Muertes;
    [Header("SALUD")]
    public AudioClip[] Salud_Tos;
    public AudioClip[] Salud_Vomito;
    public AudioClip[] Salud_Estornudo;
    [Header("AUTOMATICAS")]
    public AudioClip[] Autom_Llover; //otra vez lloviendo
    public AudioClip[] Autom_Miedo;  //esto no me gusta

    [Header("RTS")]
    public AudioClip[] Seleccion;
    public AudioClip[] Seleccion_Cansado;
    public AudioClip[] Voy;
    public AudioClip[] Voy_Cansado;
    public AudioClip[] Si;
    public AudioClip[] Nopue;
    public AudioClip[] NoPueLlegar;
    [Header("SOLICITUDES")]
    public AudioClip[] NEC_Muni;
    public AudioClip[] NEC_Med;
    public AudioClip[] NEC_Combus;
    public AudioClip[] NEC_Repara;
    public AudioClip[] NEC_Refuerzos;
    public AudioClip[] NEC_Evacuacion;
    [Header("RTS-INFORME")]
    public AudioClip[] INFOR_DETEC_Enemigo;
    public AudioClip[] INFOR_DETEC_BASE;
    public AudioClip[] INFORM_NosAtacan; //aqui unidad (tipo de unidad) nos atacan!
    public AudioClip[] EnemigoPerdido;

    [Header("Utiles")]
    public AudioClip[] Mierda; //Mierda pero que?
    public AudioClip[] Nogusta; //Esto no me gusta

    [Header("TERMINADO")]
    public AudioClip[] CurarAmigo;//Venga que no es nada
    public AudioClip[] RepararVehiculo;//Ya esta reparado y como nuevo
    public AudioClip[] MatarEnemigo; //uno menos
    public AudioClip[] EsperaOrdenes; //A la espera de ordenes
    public AudioClip[] Esposar;

    [Header("SWAT")]
    public AudioClip[] SerDetenido;
    public AudioClip[] SerSalvado;
    public AudioClip[] ResistirAlto; //Alto policia!!  Que dices anda iros de aqui
    public AudioClip[] AceptarAlto; //"""""""""            Vale vale tranquilo
    [Header("ORDENES")]
    public AudioClip[] ORD_Ve;
    public AudioClip[] ORD_Sigueme;
    public AudioClip[] ORD_Espera;
    public AudioClip[] ORD_Retirada;
    public AudioClip[] ORD_Atacar;
    public AudioClip[] ORD_DefenderObj;

    [Header("Citylife")]
    public AudioClip[] Colision;
    public AudioClip[] Agresion;

    [Header("Cortesia")]
    public AudioClip[] Gracias;
    public AudioClip[] Porfavor;
    public AudioClip[] Hola;
    public AudioClip[] Hola_Amistoso;
    public AudioClip[] Adios;
    public AudioClip[] AdiosEnfadado;

    [Header("peatones")]

    public AudioClip[] Insultar;            //
    public AudioClip[] Amenaza;             //
    public AudioClip[] RespAmenazaInsul;    //
    public AudioClip[] Paz;                 //ey tranqui //no busco lios
    public AudioClip[] RespPazNo;           // ahora vienes con esas tu no sabes con quien tratas
    public AudioClip[] Alago_M_Actitud;
    public AudioClip[] Alago_M_Ropa;             //
    public AudioClip[] Alago_H_Ropa;             //Mira que atuendos mas elegantes, como reluces amiga
    public AudioClip[] Alago_H_Actitud;          //me gusta la gente con tu actitud 
    public AudioClip[] Coment_MalaSalud;         //no tienes muy buena pinta//que mala cara tienes
    public AudioClip[] Coment_Nogustaeso;
    
    [Header("peatones")]
    public AudioClip[] ORD_BajaArma; //Baja el arma xfavor, te esty diciendo que bajes el arma!

    [Header("Nombres-Escenas")]

    public AudioClip[] Nom_LUNDUN;
    public AudioClip[] Nom_Kronos;
    public AudioClip[] Nom_Ciudadela;
    public AudioClip[] Nom_MinasNegras;
    public AudioClip[] Nom_Avernus;
    public AudioClip[] Nom_Petria;
    public AudioClip[] Nom_Termia;
    public AudioClip[] Nom_Magmaran;

    [Header("Nombres-Personajes")]
    public AudioClip[] Nombr_Pitonisa;
    public AudioClip[] Nombr_Oraculo;
    public AudioClip[] Nombr_Sreder;
    public AudioClip[] Nombr_DanNapalm;
    public AudioClip[] Nombr_Noriko;
//..............
}
