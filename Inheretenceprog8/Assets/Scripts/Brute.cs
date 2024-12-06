using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : Unit
{
    void Start()
    {
        DefineLives(4);
    }

    void Update()
    {
        Run(1 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TheCube"))
        {
            TakeDamage();
        }
    }
}
