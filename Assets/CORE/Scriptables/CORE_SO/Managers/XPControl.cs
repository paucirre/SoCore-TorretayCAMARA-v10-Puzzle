using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//AitorTorresLobato
[SerializeField]
public static class XPControl 
{
    [Header("Misiones")]
        public static int MisionGanadaXP;//ActualMision.RecompensaXP
        public static int Destruido_ObjetivoXP = 20;                                                     //____________________________________________XP extra por cumplir objetivo.tipo
        public static int Completada_OrdenAtaqueXP = 10;
        public static int Completada_OrdenDefensaXP = 10;
    [Header("Ataques")]//______________________Puntos Ataque
        public static int Matado_EnemigoXP = 10;
    [Header("Ayudas")]
        public static int RescateXP = 10; //______________________Puntos Medicos
        public static int ReparacionXP = 5; //______________________Puntos Ingenieria
    [Header("GENERICOS-Medallas")]
        public static int Capturado_EnemigoXP = 20;
        public static int Recompensa_Peq = 5;
        public static int Recompensa_Media = 10;
        public static int Recompensa_Basica = 25;
        public static int Recompensa_Estandar = 40;
        public static int Recompensa_Generosa = 60;
        public static int Recompensa_Alta = 80;
        public static int Recompensa_MuyAlta = 100;
        public static int Recompensa_Enorme = 200;
        public static int Recompensa_Desorbitada = 800;
    [Header("PENALIZACIONES")]
        public static int Penaliza_Matado_EnemigoXP = 10;
        public static int Penaliza_Matado_AmigoXP = -30; //solo se resta si: evitar fuegoAmigo es uno de los objetivos
        public static int Penaliza_Matado_CivilXP = -30; //solo se resta si: evitar muertes civiles es uno de los objetivos
        public static int Penaliza_Perdido_ObjetivoXP = -30;
    

}
