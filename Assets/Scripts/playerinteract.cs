using UnityEngine;
using Yarn.Unity;

public class playerinteract : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    private Interactable currentInteractable;
    private Movement Movement;

    private void Start()
    {
        Movement = GetComponent<Movement>();


        dialogueRunner.onDialogueStart.AddListener(DisableMovement);
        dialogueRunner.onDialogueComplete.AddListener(EnableMovement);
    }

    private void Update()
    {
        if (currentInteractable != null && Input.GetKeyDown(KeyCode.E))
        {
            if (!dialogueRunner.IsDialogueRunning)
            {
                dialogueRunner.StartDialogue(currentInteractable.dialogueNode);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Interactable interactable))
        {
            currentInteractable = interactable;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == currentInteractable?.gameObject)
        {
            currentInteractable = null;
        }
    }

    private void DisableMovement()
    {
        Movement.canMove = false;
    }

    public void EnableMovement()
    {
       Movement.canMove = true;
    }
}
