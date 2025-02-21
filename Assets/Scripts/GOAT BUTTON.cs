using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GOATBUTTON : MonoBehaviour
{
    [SerializeField]
    Button horsebtn;

    [SerializeField]
    TMP_Text horsetxt;

    void Start()
    {
        horsebtn.onClick.AddListener(ButtonTest);
    }

    void ButtonTest()
    {
        horsetxt.text = "FUN FACTS ABOUT HORSES!\r\nHorses can sleep standing straight up.\r\nHorses CANNOT puke.\r\nIt can take anywhere from 9 months, to a year to regrow a full horse hoof.\r\nHorses produce approx. 10 gallons of saliva a day.\r\nHorses have 205 bones in the body, while people have 206.\r\nHorses have very large eyes\r\nThanks to their impressive vision and eye size, horses can see 350 degrees around them.\r\nHorses have 16 muscles in each ear.\r\nMost horses are actually born at night.\r\n\r\n";

        Debug.Log("Horse Button clicked");
    }
}

