using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit, IMovable, IDamagable
{
    //Dit zorgt ervoor dat de player zijn eigen 
    public override void Move() 
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }

    void Update() 
    {
        //dit laat hem lopen op de manier die is overwritten door dit script
        Move(); 
    }

    //dit defineert de levens en speed waneer de game opstart
    void Start() 
    {
        DefineLives(4);
        DefineSpeed(4);
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
