using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    //RESPAWN
    Vector3 spawnPosition;
    public GameObject Enemigo;
    public GameObject PuntoSpawn;
    public int NumeroEnemigos;
    public int tiempoSpawn = 1;


    // Update is called once per frame
    void Update()
    {
        Spawneando();
    }


    //RESPAWN ENEMIGOS
    public void Spawneando()
    {
        StartCoroutine("GenerarEnemigos");
    }

    IEnumerator GenerarEnemigos()
    {

        while (true)
        {
            spawnPosition = PuntoSpawn.transform.position;
            if (GameObject.FindGameObjectsWithTag("Enemigo").Length < 3)
            {
                Instantiate(Enemigo, spawnPosition, this.transform.rotation);
                yield return new WaitForSeconds(tiempoSpawn);
            }
            yield return new WaitForSeconds(tiempoSpawn);
        }
        
    }



}
