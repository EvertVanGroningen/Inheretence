using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Unit : MonoBehaviour, IMovable, IDamagable
{
    public int health; //De levenspunten van een unit
    public int Health => health; //helpt de health defineren
    public float speed; //snelheid van een unit
    public float moveSpeed => speed; //helpt de speed defineren
    public float rotationSpeed = 180f; //hoe snel een unit draait al moet de unit draaien
    public void Run(float Speed) //word aangeroepen door elke unit en laat ze bewegen
    {
        transform.position += new Vector3 (Speed, 0, 0);
    }

    //stelt de levens van een unit in
    public void DefineLives(int punten) 
    {
        health = punten;
    }

    //stelt de snelheid van een unit in
    public void DefineSpeed(int sonic) 
    {
        speed = sonic;
    }

    //Haalt health van de unit af en bekijkt of ze nog meer dan 0 health hebben anders worden ze verwijderd
    public virtual void TakeDamage()
    {
        health = health - 1;
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }

    //helpt de player bewegen
    public virtual void Move() 
    {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
}
