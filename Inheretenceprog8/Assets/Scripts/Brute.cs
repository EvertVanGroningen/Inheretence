using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : Unit, IMovable, IDamagable
{
    //dit defineert alles waneer de game opstart
    void Start() 
    {
        DefineLives(4);
        DefineSpeed(1);
    }

    void Update()
    {
        //dit laat hem rennen
        Move(); 
    }

    //Dit zorgt ervoor dat waneer de unit word geraakt dat hij damage neemt
    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("TheCube"))
        {
            TakeDamage();
        }
    }
}
