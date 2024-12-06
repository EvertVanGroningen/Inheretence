using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Unit, IMovable, IDamagable
{
    public bool isVisible;
    void Start()
    {
        DefineLives(2);
        DefineSped(2);
        StartCoroutine(ToggleVisibility());
    }

    void Update()
    {
        //Run(2 * Time.deltaTime);
        Move();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TheCube"))
        {
            TakeDamage();
        }
    }

    private IEnumerator ToggleVisibility()
    {
        while (true)
        {
            Renderer renderer = GetComponent<Renderer>();
            yield return new WaitForSeconds(0.5f);
            isVisible = !isVisible;
            renderer.enabled = isVisible;
            yield return new WaitForSeconds(3f);
            isVisible = !isVisible;
            renderer.enabled = isVisible;
        }
    }
}
