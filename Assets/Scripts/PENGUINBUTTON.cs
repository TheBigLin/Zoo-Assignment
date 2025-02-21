using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PENGUINBUTTON : MonoBehaviour
{
    [SerializeField]
    Button penguinbtn;

    [SerializeField]
    TMP_Text penguintxt;

    void Start()
    {
        penguinbtn.onClick.AddListener(ButtonTest);
    }

    void ButtonTest()
    {
        penguintxt.text = "FUN FACTS ABOUT PENGUINS:\r\nPenguins can swim at speeds up to 10mph.\r\nPenguins are excellent divers and are capable of diving to depths of 800ft.\r\nPenguins are able to drink seawater.\r\nPenguins have no teeth.\r\nEmperor penguins incubate eggs with their feet.\r\nPenguins are waterproof!\r\nWhen they�re together in the water as a group, it�s called a raft\r\n";
        Debug.Log("Penguin Button clicked");
    }
}
