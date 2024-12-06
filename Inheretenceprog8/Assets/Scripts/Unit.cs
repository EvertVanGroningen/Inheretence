using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Unit : MonoBehaviour, IMovable, IDamagable
{
    public int health;
    public int Health => health;
    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;
    public void Run(float Speed)
    {
        transform.position += new Vector3 (Speed, 0, 0);
        Move();
    }

    public void DefineLives(int punten)
    {
        health = punten;
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
