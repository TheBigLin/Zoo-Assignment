using UnityEngine;
using Yarn.unity;
 // public class CamelInteract : MonoBehaviour
{
    // refernece our runner
  // public DialogueRunner dialogueRunner;

   
    

    // boolean that determines if within the range in which the yarn script can be activated.
    private bool = inzonetospeak = false;


    // Update is called once per frame
    void Update()
    {
        if (inzonetospeak && Input.GetKeyDown(KeyCode.E))
        {
            TalkToCamel();
        }

    }
    // start the dialogue runner based on name
    private void TalkToCamel();
    {
    if (inzonetospeak != null)
    {
        dialogueRunner.StartDialogue(TalkToCamel);
    }

private void OnTriggerEnter(BoxCollider2D)
{
    if (other.CompareTag("Player"))
    {
        inzonetospeak = true;
    }
    if (other.CompareTag("Player"))
    {
        inzonetospeak = false;
    }




}
