using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;                                      //Gestiona archivos
using System.Runtime.Serialization.Formatters.Binary; //Gestiona archivos binarios en tiempo de ejecucion?

//OBJETIVO:_______________________________________________________________________________________________________________________________________.
//                                                                                                                                                |
//  Que guarde la estructura de datos de toda la escena y la cargue (intel,marcadores,triggers,modulos,) y (Grupos con entidades y contenedores)  |
//________________________________________________________________________________________________________________________________________________|
//QUEDA://                                                                                                                                        |
//                                                                                                                                                |
//      Que guarde en jerarquia toda la escena no la clase entidad solo                                                                           |
//              Que guarde nombre de usuario en .save o nombre mision?                                                                            |
//                 Posible guardado en .json                                                                                                      |
//                     Slots de guardado por usuario?                                                                                             |
//________________________________________________________________________________________________________________________________________________!

//  Filestream crear,escribir,abrir,cerrar,eliminar 


/*
//public static class SaveLoadSecene
{
    public static string Ruta_Save_Historia = "/Escena.binary";           //Ruta de archivos de guardado de la historia
    public static string Ruta_Save_Misiones = "/Escena.binary";          //
    public static string Ruta_Save_PersonalMision = "/Escena.binary";    //

    public static int[] Cantidad_Slots_Guardado;
    public static int SlotGuardado_Seleccionado;
          
    public static void SaveScene(Entidad _entidad)                        //Recibe la clase Entidad_Serializable que va a serializar
    {
        BinaryFormatter formatter = new BinaryFormatter();                        //Necesario para gestionar archivos binarios
        string path = Application.persistentDataPath + Ruta_Save_Historia;          //Ruta de SaveEntity
        FileStream stream = new FileStream(path, FileMode.Create);                //Acedemos al archivo en modo creacion

        EntitiData data = new EntitiData(_entidad);                               //Instanciamos el objeto data y lo igualamos a los datos recibidos por la funcion (_entidad)
        formatter.Serialize(stream, data);                                    //Escribir en archivo lo contenido en data
        stream.Close();                                                       //Se cierra el archivo                   
    }
    public static EntitiData LoadScene()                                  //Devuelve Entidad_Serializable Lee .SAVE
    {                                
        string path = Application.persistentDataPath + Ruta_Save_Historia;        //Ruta en la que se encuentra el archivo salvado
        if (File.Exists(path))                                                    //Si El archivo existe
       { 
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            EntitiData data = formatter.Deserialize(stream) as EntitiData;
            stream.Close();
            return data;
       }

        else
        {
            Debug.Log("Savefile no enontrado en" + path);
            return null;
        }
    }
}
//public static EliminarSaveEntiti (){


    */


