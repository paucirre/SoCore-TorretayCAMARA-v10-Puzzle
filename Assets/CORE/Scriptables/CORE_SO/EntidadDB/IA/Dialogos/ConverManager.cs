using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConverManager : MonoBehaviour
{

    
    public Dialogo[] dialogos;      //Aquí se asignarán los Scriptable Object desde el inspector, se reproduciran en fila"
    public Text dialogTextBox;      //El cajón de texto donde se imprimirán los diálogos 
    public AudioSource Narrador;    //aqui el audiosource del narrador
    public SpriteRenderer spritePosition; //Un sprite en scena que se cambiará por el sprite del personaje que esté hablando
    private int dialogCounter; //Contador para saber qué diálogo hay que mostrar tras finalizar el actual
    //Muestra el primer diálogo al arrancar

    public int TiempoDialogo;

    private void Start()
    {
        MostrarDialogo(dialogos[dialogCounter]);
    }

    private void Update()
    {

        //Se ejecuta al pulsar el botón izquierdo del ratón
        if (Input.GetMouseButtonUp(0))
        {
            dialogCounter++;
            //Muestra el diálogo y tras pulsar el ratón sigue habiendo más
            if (dialogCounter < dialogos.Length)
            {
                MostrarDialogo(dialogos[dialogCounter]);
            }
            //Si no hay más diálogos oculta el texto y el sprite
            else
            {
                dialogTextBox.gameObject.SetActive(false);
                spritePosition.gameObject.SetActive(false);
            }
        }
    }

    //Asigna los valores del diálogo actual a los objetos de la escena
    private void MostrarDialogo(Dialogo currentDialog)
    {
        spritePosition.sprite = currentDialog.characterSprite;
        dialogTextBox.text = currentDialog.dialogoTexto;
    }
}

