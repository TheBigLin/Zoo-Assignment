using UnityEngine;

public abstract class Animal
{
    public abstract float Hunger();
    public abstract float Energy();
    public abstract float Thirst();

    public float energy = 0.0f;
    public float hunger = 0.0f;
    public float thirst = 0.0f;
}

public class Goat : Animal, IInteractable, IFeed
{
    public override float Hunger()
    {
        return (hunger) + 2.0f;
    }
    public override float Energy()
    {
        return (energy) + 100.0f;
    }

    public override float Thirst()
    {
        return (thirst) + 25.0f;
    }

    public void Faint()
    {
        Debug.Log("AHHH-...");
    }

    public float destoryenemies;
    public float poop;

    public void Interact()
    {
        Debug.Log("goat faints and falls over");
    }

    public void Feed()
    {
        Debug.Log("Munch Munch Munch");
    }

    
}

public class Camel : Animal, IInteractable, IFeed
{
    public override float Hunger()
    {
        return (hunger) + 10.0f;
    }
    public override float Energy()
    {
        return (energy) + 50.0f;
    }
    public override float Thirst()
    {
        return (thirst) + 1000000.0f;
    }

    public void Hump()
    {
       Debug.Log("I love water. I'm literally full of it");
    }

    public float storewater;

    public void Interact()
    {
        Debug.Log("Gave Camel Water");
    }
    public void Feed()
    {
        Debug.Log("Slurp slurp");
    }
}

public class Penguin : Animal, IInteractable, IFeed
{
    public override float Hunger()
    {
        return (hunger) + 50.0f;
    }

    public override float Energy()
    {
        return (energy) + 100.0f;
    }
    public override float Thirst()
    {
        return (thirst) + 75.0f;
    }

    public void Slide()
    {
        Debug.Log("Don't mind me sliding past ya");
    }
    public float Kowaslkianalysis; // shoutout the madagascar movie. 

    public void Interact()
    {
        Debug.Log("Give penguin water");
    }
    public void Feed()
    {
        Debug.Log("rips fish in half");
    }
}

public class Horse : Animal, IInteractable, IFeed
{
    public override float Hunger()
    {
        return (hunger) + 100.0f;
    }

    public override float Energy()
    {
        return (energy) + 100.0f;
    }
    public override float Thirst()
    {
        return (thirst) + 50.0f;
    }

    public void Scream()
    {
        Debug.Log("NEIGH");
    }

    public Quaternion Rotategalloping()
    {
        return Quaternion.Euler(5.0f, 0.7f, 420.0f);
    }

    public float eathay;
    public float racing; 

    public void Interact()
    {
        Debug.Log("Give horse a apple");
    }
    public void Feed()
    {
        Debug.Log("the horse starts munching on the apple");
    }
}
