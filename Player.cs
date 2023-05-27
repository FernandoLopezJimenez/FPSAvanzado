using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    public Armas francotirador;
    public Armas Lanzagranadas;


    // Update is called once per frame
    void Update()
    {
        
       Ataque01(); //ATAQUES HEREDADOS 
       Ataque02(); //DE CHARACTER.
    }

    public override void Ataque01() //Heredado de character 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            francotirador.Disparo("Perforador"); //A este disparo le he puesto nombre usando una sobrecarga.
        }

    }

    public override void Ataque02() //Heredado de character 
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Lanzagranadas.Disparo();
        }
    }

}
