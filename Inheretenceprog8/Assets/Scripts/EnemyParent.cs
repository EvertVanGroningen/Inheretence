using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float Lives;
    public void Run(float Speed)
    {
        transform.position += new Vector3 (Speed, 0, 0);
    }

    public void DefineLives(float punten)
    {
        Lives = punten;
    }

    public void OnHit(float damage)
    {
        Lives = Lives - damage;
        if (Lives < 0)
        {
            Destroy(gameObject);
        }
    }
}
