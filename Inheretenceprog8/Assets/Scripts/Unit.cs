using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Unit : MonoBehaviour, IMovable, IDamagable
{
    public int health;
    public int Health => health;
    public float sped;
    public float moveSpeed => sped;
    public float rotationSpeed = 180f;
    public void Run(float Speed)
    {
        transform.position += new Vector3 (Speed, 0, 0);
    }

    public void DefineLives(int punten)
    {
        health = punten;
    }

    public void DefineSped(int sonic)
    {
        sped = sonic;
    }

    public virtual void TakeDamage()
    {
        health = health - 1;
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }

    public virtual void Move()
    {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
}
