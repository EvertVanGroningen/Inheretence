using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Unit, IMovable, IDamagable
{
    public bool isVisible; //om te kijken of de elf momenteel ontzichtbaar is
    //dit defineert alles waneer de game opstart
    void Start()
    {
        DefineLives(2);
        DefineSpeed(2);
        StartCoroutine(ToggleVisibility());
    }

    void Update() 
    {
        //dit laat hem rennen
        Move(); 
    }

    //Dit zorgt ervoor dat waneer de unit word geraakt dat hij damage neemt
    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("TheCube"))
        {
            TakeDamage();
        }
    }

    //Dit maakt de elf ontzichtbaar voor een halve seconde met een pauze van 3 seconden
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
