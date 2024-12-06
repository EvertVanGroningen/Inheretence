using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit, IMovable, IDamagable
{
    public override void Move()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }

    void Update() 
    { 
        Move();
    }

    void Start()
    {
        DefineLives(4);
        DefineSped(4);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TheCube"))
        {
            TakeDamage();
        }
    }
}
