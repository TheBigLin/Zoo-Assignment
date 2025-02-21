using UnityEngine;
using Yarn.Unity;

public class playerinteract : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public SignInteract Interact;
    public Movement movement;

    public void Start()
    {
        movement = GetComponent<Movement>();

        dialogueRunner.onDialogueStart.AddListener(DisableMovement);
        dialogueRunner.onDialogueComplete.AddListener(EnableMovement);
    }

    public void Update()
    {
        if (Interact != null && Input.GetKeyDown(KeyCode.E))
        {
            if (!dialogueRunner.IsDialogueRunning)
            {
                dialogueRunner.StartDialogue(Interact.dialogueNode);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Interact interactable))
        {
            Interact = interactable;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == Interact?.gameObject)
        {
            Interact = null;
        }
    }

    private void DisableMovement()
    {
       // movement.canMove = false;
    }
   
    public void EnableMovement()
    {
       // movement.canMove = true;
    }
}

