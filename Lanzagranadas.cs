using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzagranadas : Armas
{

    //DISTANCIA RAYCAST E INSTANCIADOR DE PARTICULAS MUERTE DE ENEMIGO
    public float maxRadioDebug;
    public GameObject ExplosionGranada;
    public float maxDistanceThrow;
    public float radio;
    public float delay;
    [SerializeField] LayerMask Destructible;

    private void Start()
    {
        StartCoroutine("Explosion");
    }


    public override void Disparo()
    {

        //OVERLAPSPHERE
        RaycastHit hit;
        if (Physics.Raycast(this.transform.position, this.transform.forward, out hit, maxDistanceThrow))
        {
            //Donde toque, si toco algo.
            Collider[] hits;
            hits = Physics.OverlapSphere(hit.point, radio, Destructible);

            //Efecto visual disparo y destruccion de objetos
            var EfectoGranada = Instantiate(ExplosionGranada, hit.point, this.transform.rotation);
            foreach (Collider i in hits)
            {
                //Compruebo los tags en i y destruyo los gameobjects que tengan estos tags en el radio de la esfera.
                if ((i.transform.tag == "Pared") || (i.transform.tag == ("Enemigo")))
                {
                    Destroy(i.gameObject, delay);
                    Destroy(EfectoGranada, delay);
                }

            }

        }

    }

    

    virtual public void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(this.transform.position, maxRadioDebug);
        }

        
    
}


