using UnityEngine;
//using Yarn.unity;

public class CamelInteract : MonoBehaviour
{
    // refernece our runner
    //public DialogueRunner dialogueRunner;

    // boolean that determines if within the range in which the yarn script can be activated.
    private bool inzonetospeak = false;

// Update is called once per frame
    void CamelInteractionVoid()
    {
        if (inzonetospeak && Input.GetKeyDown(KeyCode.E))
        {
            TalkToCamel();
        }

    }
    // start the dialogue runner based on name
    void TalkToCamel()
    {
        if (inzonetospeak != null)
        {
            //dialogueRunner.StartDialogue(TalkToCamel);
        }
    }

    // TODO - use autocomplete to type this for you with correct syntax
    //void OnTriggerEnter2D(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        inzonetospeak = true;
    //    }
    //    else (other.CompareTag("Player"))
    //    {
    //        inzonetospeak = false;
    //    }
    //}
}
