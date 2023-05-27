using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armas : MonoBehaviour
{
    public string nombreArma;
    


    private void Start()
    {
       
    }


    virtual public void Disparo()
    {
   
    }

    virtual public void Disparo(string nombreArma)  //He puesto la sobrecarga aquí porque ya entiendo para que sirve pero
    {                                               //al no haber un sistema de vida o tipos de daño y cosas así
                                                   //la he dejado aquí, en player podrás ver el nombre del disparo
    }                                              //y en Francotirador el uso del metodo sobrecargado.
}
