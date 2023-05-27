using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Character : MonoBehaviour
{
    //NavMeshAgent PARA MOVIMIENTO DE IA DE LOS NPC Y ENEMIGOS.
    protected NavMeshAgent agenteNav;

    //ATRIBUTOS COMPARTIDOS
    public string nombre;


    void Start()
    {
        agenteNav = this.GetComponent<NavMeshAgent>();   
    }
       


    //METODOS VIRTUALES
    virtual public void Navmesh()
    {
        agenteNav = this.GetComponent<NavMeshAgent>();  //Esto si lo que lo puse aquí pensando en NPCs y enemigos para que lo pudiesen heredar.
    }

    virtual public void Ataque01()
    {
       
    }

    virtual public void Ataque02()
    {

    }

    virtual public void Movimiento()
    {
    
    }

 

}







