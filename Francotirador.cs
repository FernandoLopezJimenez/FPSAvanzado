using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Francotirador : Armas
{

    //DISTANCIA RAYCAST E INSTANCIADOR DE PARTICULAS MUERTE DE ENEMIGO
    public float maxDistanceShot;
    public float maxDistanceDebug;
    public GameObject DisparoBala;


    public override void Disparo(string nombreDisparo) //He usado una sobrecarga para darle nombre al disparo en Player
    {

        // Array de RaycastHit -> Info de TODO lo que toque el rayo.
        RaycastHit[] hitColliders = Physics.RaycastAll(this.transform.position, this.transform.forward, maxDistanceShot);


        //Cada elemento del tipo "hit" en el array RaycastHit[] quiero hacer:
        foreach (RaycastHit hit in hitColliders)
        {
            //Comprobar si tiene el tag "Enemigo".   
            if (hit.transform.gameObject.tag == "Enemigo")
            {
                //Hago el debug, instancio una variable de bala y después destruyo al enemigo y la variable de bala en 1 segundo.
                Debug.Log(hit.collider.tag = "Enemigo"); // Dejo el debug para ver en en la escena el impacto.

                var EfectoBala = Instantiate(DisparoBala, hit.point, this.transform.rotation);
                Destroy(hit.collider.gameObject);
                Destroy(EfectoBala, 1);
            }


            // Este código de abajo es el mismo pero usando for, lo hice porque de repente el foreach dejó
            // de funcionar, ignoraba el tag y destruia todos los elementos sin haber modificado el código
            // No se si fué un bug o que, pero cuando volvió a funcionar cambiando los nombres del raycast
            // igualmente dejé el código con for para que me digas si está bien hecho. :)

            /* if (Input.GetKeyDown(KeyCode.Mouse0))
            {
              //RaycastAll
              RaycastHit[] hitColliders;
              hitColliders = Physics.RaycastAll(Pistola.position, Pistola.forward, maxDistanceShot);

              for (int i = 0; i < hitColliders.Length; i++)
              {
                  RaycastHit hit = hitColliders[i];
                  Debug.Log(hitColliders[i].transform.name);
                  if (hit.transform.gameObject.tag == "Enemigo")
                  {
                      var EfectoBala = Instantiate(DisparoBala, hit.point, this.transform.rotation);
                      Destroy(hit.collider.gameObject);
                      Destroy(EfectoBala, 1);
                  }
              } */
        }

    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(this.transform.position, this.transform.forward * maxDistanceDebug);


    }
}

