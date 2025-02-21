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

public class Goat : Animal
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
}

public class Camel : Animal
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
}

public class Penguin : Animal
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
}

public class Horse : Animal
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

}
