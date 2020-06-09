using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "dialogo_", menuName = "Etereas/IA/Dialogos/dialogo")]
public class Dialogo : ScriptableObject
{
    
    public string dialogoTexto;
    public AudioClip DialogoVoz;
    public AudioSource Emisor;
    public Sprite characterSprite;

    public Disponibilidad disponibilidadDialogo;

}
