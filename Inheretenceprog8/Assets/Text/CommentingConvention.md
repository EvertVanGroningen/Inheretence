Ik heb de Player.cs, Elf.cs, Brute.cs en de Unit.cs scripts aangepast en in gecomment

Comments:
In de comments wil ik zelf zien wat het doel is van elke functie en hoe die werkt. 
In de comments wil ik niet zien hoe het precies werkt en dat het te lang is.

Een voorbeeld van een goede comment:
//Haalt health van de unit af en bekijkt of ze nog meer dan 0 health hebben anders worden ze verwijderd
public virtual void TakeDamage()
{
    health = health - 1;
    if (health < 0)
    {
        Destroy(gameObject);
    }
}

Een voorbeeld van een slecht comment:
//Als de TakeDamage script word aangeroepen dan haalt het de health points van een unit op en doet het de health -1 en daarna bekijkt het of de health wel hoger is dan 0 en al is dat niet zo dat word de unit verwijderd
public virtual void TakeDamage()
{
    health = health - 1;
    if (health < 0)
    {
        Destroy(gameObject);
    }
}