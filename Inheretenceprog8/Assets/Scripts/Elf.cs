using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Unit
{
    public bool isVisible;
    void Start()
    {
        DefineLives(2);
        StartCoroutine(ToggleVisibility());
    }

    void Update()
    {
        Run(2 * Time.deltaTime);
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
