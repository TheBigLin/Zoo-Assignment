using UnityEngine;
using Yarn.Unity;

public class CAMELSTARTER : MonoBehaviour
{
    //refernece our runner
    public DialogueRunner dialogueRunner;
    public string NodeName;

    // boolean that determines if within the range in which the yarn script can be activated.
    private bool inzonetospeak = false;



    void Start()

    {

        dialogueRunner = Object.FindAnyObjectByType<DialogueRunner>();
    }

    

        // Update is called once per frame



      
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                inzonetospeak = true;
            }


            void OnTriggerExit2D(Collider2D other)
            {
                if (other.CompareTag("Player"))
                {
                    inzonetospeak = false;
                }

            void Update()
            {
                if (inzonetospeak && Input.GetKeyDown(KeyCode.E))
                {
                    dialogueRunner.StartDialogue(NodeName);
                }




            }
        }
    }
}
