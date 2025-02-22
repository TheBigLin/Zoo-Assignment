using UnityEngine;

public class Movement
{

    public GameObject ZOO_GOAT;
    public GameObject ZOO_HORSE;
    public GameObject ZOO_CAMEL;
    public GameObject ZOO_PENGUIN;
    float moveSpeed = 50.0f;



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


        if (WhichZooAnimal == Camel)
        {
            interact();
        }
        else if (WhichZooAnimal == Horse)
        {

        }
        else if (WhichZooAnimal == Penguin)
        {

        }
        else if (WhichZooAnimal == Goat)
        {

        }

        Vector3 movement = direction * moveSpeed * dt;
        transform.position += movement;

         public string WhichZooAnimal;
         float dt = Time.deltaTime;
         Vec2 direction = Vec2.zero;
    }
} 


      















