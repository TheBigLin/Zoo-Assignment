using UnityEngine;

public class Movement
{

    public GameObject GOAT;
    public GameObject HORSE;
    public GameObject CAMEL;
    public GameObject PENGUIN;
    float moveSpeed = 50.0f;




    private bool canSelect = false;
    private IInteractable ChosenAnimal;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //     public string WhichZooAnimal;
        float dt = Time.deltaTime;
        Vector2 direction = Vector2.zero;
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

        Vector3 movement = direction * moveSpeed * dt;
        transform.position += movement;



        if (canSelect && Input.GetKeyDown(KeyCode.E) && ChosenAnimal != null)
        {
            ChosenAnimal.Interact();
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject == GOAT)
        {
            ChosenAnimal = GOAT.GetComponent<IInteractable>();
            canSelect = true;
        }
        else if (other.gameObject == HORSE)
        {
            ChosenAnimal = HORSE.GetComponent<IInteractable>();
            canSelect = true;
        }
        else if (other.gameObject == CAMEL)
        {
            ChosenAnimal = CAMEL.GetComponent<IInteractable>();
            canSelect = true;
        }
        else if (other.gameObject == PENGUIN)
        {
            ChosenAnimal = PENGUIN.GetComponent<IInteractable>();
            canSelect = true;
        }
    }
}

















