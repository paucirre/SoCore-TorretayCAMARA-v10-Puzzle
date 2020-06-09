using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;                                      //Gestiona archivos
using System.Runtime.Serialization.Formatters.Binary; //Gestiona archivos binarios en tiempo de ejecucion?
//AitorTorresLobato
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

public static class SaveLoad
{

    public static EscenaContenedor _EscenaContenedor; //puede usarse para SAVESLOTS


    public static string Ruta_Save_Historia = "/Endidad.binary";           //Ruta de archivos de guardado de la historia
    public static string Ruta_Save_Misiones = "/Endidad.binary";          //Ruta de archivos de guardado de la misiones
    public static string Ruta_Save_PersonalMision = "/Endidad.binary";    //Ruta de archivos de guardado de la misiones personales creadas desde el editor

    public static int[] Cantidad_Slots_Guardado;
    public static int SlotGuardado_Seleccionado;

    public static void SaveEntity_Binary(Entidad _entidad)                        //Recibe la clase Entidad_Serializable que va a serializar
    {
        BinaryFormatter formatter = new BinaryFormatter();                        //Necesario para gestionar archivos binarios
        string path = Application.persistentDataPath + Ruta_Save_Historia;             //Ruta de SaveEntity
        FileStream stream = new FileStream(path, FileMode.Create);                //Acedemos al archivo en modo creacion<<<<<----creamos el archivo!?

        EntitiData data = new EntitiData(_entidad);                     //Instanciamos el objeto data y lo igualamos a los datos recibidos por la funcion (_entidad)
        formatter.Serialize(stream, data);                              //Escribir en archivo lo contenido en data
        stream.Close();                                                 //Se cierra el archivo <<---se deja de escribir en el
        



    }
    public static EntitiData LoadEntity_Binary()                                  //Devuelve Entidad_Serializable (entityData) Lee .SAVE
    {
        string path = Application.persistentDataPath + Ruta_Save_Historia;        //Ruta en la que se encuentra el archivo salvado
        if (File.Exists(path))                                                    //Si El archivo existe
        {
            BinaryFormatter formatter = new BinaryFormatter();                    //abrimos otra vez el formatter para gestionar archivos binarios
            FileStream stream = new FileStream(path, FileMode.Open);              //Abrimos el archivo en la ruta indicada
            EntitiData data = formatter.Deserialize(stream) as EntitiData;        //Saca todos esos datos y vuelcalos en una "instancia" de tipo EntityData que llamamos "data"
            stream.Close();                                                       //Cierra archivo
            return data;                                                          //devuelve la info almacenada en "data" osea...la clase entitydata que contiene...
        }

        else
        {
            Debug.Log("Savefile no enontrado en" + path);
            return null;
        }
    }
    public static string ActualUserName;      //no consigo recordar por que puse esto aqui....
    //creo que para referenciar el archivo con el nombre del user actual










    //__________________________JSON SAvE LOAD_______________________________________

    public static bool IsSaveFile()//Comprueba Si hay archivo con ese nombre y lo devuelve
    {
        return Directory.Exists(Application.persistentDataPath + "/game_save");
    }

    //llama a la funcion de arriba para comprobar si el archivo/carpeta existen, si no crea uno en esa ruta
    public static void SaveEscenaJSON()
    {

        if (!IsSaveFile())
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/game_save");                   //si No hay CREA archivo con ese nombre---//Crea Archivo
        }
        if (!Directory.Exists(Application.persistentDataPath + "/game_save/character_data"))            //si No Existe la carpeta/Directorio
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/game_save/character_data");    //Crea la carpeta en esa ruta
        }

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/game_save/character_data/character_save");
        var json = JsonUtility.ToJson(_EscenaContenedor);//pasa los datos de la escena
        bf.Serialize(file, json);
        file.Close();
    }
    public static void LoadEscenaJSON()
    {
        if (!Directory.Exists(Application.persistentDataPath + "/game_save/character_data"))                        //Si el directorio no existe 
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/game_save/character_data");                //Se crea
        }
        BinaryFormatter bf = new BinaryFormatter();                                                                 //Creamos el Formateador"

        if (File.Exists(Application.persistentDataPath + "/game_save/character_data/character_save"))               //Si El archivo existe
        {
            FileStream file = File.Open(Application.persistentDataPath + "/game_save/character_data/character_save", FileMode.Open); //abre el archivo
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), _EscenaContenedor);                                          //loading EscenaContenedor 
            file.Close();
        }





    }

}



//public static EliminarSaveEntiti (){





