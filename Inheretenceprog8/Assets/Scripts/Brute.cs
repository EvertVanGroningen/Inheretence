using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : Unit, IMovable, IDamagable
{
    void Start()
    {
        DefineLives(4);
        DefineSped(1);
    }

    void Update()
    {
        //Run(0.5f * Time.deltaTime);
        Move();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TheCube"))
        {
            TakeDamage();
        }
    }
}
