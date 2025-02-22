using UnityEngine;

public class Movement : IInteractable
{

    public GameObject Goat;
    public GameObject Horse;
    public GameObject Camel;
    public GameObject Penguin;
    float moveSpeed = 50.0f;

    public string WhichZooAnimal;
    float dt = Time.deltaTime;
    Vector2 direction = Vector2.zero;



   

    void Start()
    {
     
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }


        if (WhichZooAnimal == CAMEL)
        {
           Interact();
        }
        else if (WhichZooAnimal == HORSE)
        {
            Interact();
        }
        else if (WhichZooAnimal == PENGUIN)
        {
            Interact();
        }
        else if (WhichZooAnimal == GOAT)
        {
            Interact();
        }

        Vector3 movement = direction * moveSpeed * dt;
        transform.position += movement;
        
        
    }
}