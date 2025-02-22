using UnityEngine;

public class Movement : IInteractable
{

    public GameObject Goat;
    public GameObject Horse;
    public GameObject Camel;
    public GameObject Penguin;
    float moveSpeed = 50.0f;

    public string WhichZooAnimal;
    
    Vector2 direction = Vector2.zero;
   

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


      if (WhichZooAnimal == CAMEL)
      {
         void Interact()
          {
              Debug.Log("TestTEst");
          }
      }
      else if (WhichZooAnimal == HORSE)
      {
         void Interact()
         {
           Debug.Log("Test2");
         }
      }
      else if (WhichZooAnimal == PENGUIN)
      {
          void Interact()
          {
            Debug.Log("test3");
          }
      }
      else if (WhichZooAnimal == GOAT)
      {
          void Interact()
          {
              Debug.Log("test4");
          }
      }
        
        
    }
}