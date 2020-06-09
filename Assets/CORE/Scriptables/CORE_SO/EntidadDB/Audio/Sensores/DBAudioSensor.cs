using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DB_Audio_Sensor_", menuName = "DB/DB_AudioSensor")]
public class DBAudioSensor : ScriptableObject
{
    public AudioClip Detectado_Aliado;
    public AudioClip Perdido_Aliado;
    [Space(10)]
    public AudioClip Detectado_Enemigo;
    public AudioClip Perdido_Enemigo;
}
