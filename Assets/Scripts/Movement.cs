using UnityEngine;

public class Movement : MonoBehaviour //IInteractable
{

    public GameObject Goat;
    public GameObject Horse;
    public GameObject Camel;
    public GameObject Penguin;
    float moveSpeed = 50.0f;

    public string WhichZooAnimal;
    Vector2 direction = Vector2.zero;
    float dt;
   

    void Start()
    {
        
        float dt = Time.deltaTime;
        Vector2 direction = Vector2.zero;
        Vector3 movement = direction * moveSpeed * dt;
        transform.position += movement;
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


    //if (WhichZooAnimal == "Camel")
    //{
    //      Interact("Camel");
    //}
    //else if (WhichZooAnimal == "Horse")
    //{
    //      Interact("Horse");
    //}
    //else if (WhichZooAnimal == "Penguin")
    //{
    //      Interact("Penguin");
    //}
    //else if (WhichZooAnimal == "Goat")
    //{
    //      Interact("goat");
    //}
    //
    //void Interact()
    //{
    //  Debug.Log("Interacting with " + WhichZooAnimal);
    //}
    //
    //void Interact(string animal)
    //  {
    //      Debug.Log("Interacting with " + animal);
    // }
        
        
    }
}