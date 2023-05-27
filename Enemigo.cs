using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : Character
{
    //PATRULLA
    public GameObject[] navPoints;
    public int currentDest;


    void Start()
    {
        Navmesh();
        StartCoroutine("AlternarPatrulla");
    }

    void Update()
    {
       Movimiento();
    }

    public override void Movimiento() //Heredado de Character.
    {
        if ((this.transform.position - navPoints[currentDest].transform.position).magnitude > 3)
        {
            agenteNav.SetDestination(navPoints[currentDest].transform.position);
        }
        else
        {
            currentDest = Random.Range(0, navPoints.Length);
        }

    }

    IEnumerator AlternarPatrulla() //ESTA CORRUTINA LA HE DEJADO AQUÍ PORQUE ES PROPIETARIA
                                   //DEL ENEMIGO, NO SE HEREDA.
    {

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(4, 30));
            agenteNav.isStopped = true;

            yield return new WaitForSeconds(Random.Range(2, 6));
            agenteNav.isStopped = false;
        }

    }

}
