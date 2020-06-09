using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public GameObject Enemigo_A;
    public int rangoSpawn;
    public int EnemigosGenerados;
    void Start()
    {
        EnemigosGenerados = 0;
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("u")) { GameObject EnemigoClon = 
                
                
                Instantiate
                (Enemigo_A, 
                new Vector3(
                Random.Range(this.transform.position.x - rangoSpawn,this.transform.position.x +rangoSpawn),   
                Random.Range(this.transform.position.y - rangoSpawn, this.transform.position.y -rangoSpawn), 
                Random.Range(this.transform.position.z - rangoSpawn, this.transform.position.z + rangoSpawn)), Quaternion.identity);

            EnemigoClon.name = "EnemigoClon" + EnemigosGenerados++;

         


        }
        


        //Instantiate(Enemigo_A [UnityEngine.Random.Range(0, 8)], transform.position, this.transform.rotation);
    }
}
