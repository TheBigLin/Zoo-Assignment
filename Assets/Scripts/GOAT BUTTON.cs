using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GOATBUTTON : MonoBehaviour
{
    [SerializeField]
    Button goatbtn;

    [SerializeField]
    TMP_Text goattxt;

    void Start()
    {
        goatbtn.onClick.AddListener(ButtonTest);
    }

    void ButtonTest()
    {
        goattxt.text = "FUN FACTS ABOUT GOATS!\r\nThere’s over 450 million goats in the world, with China having over 170 million of them.\r\nThey’re close relatives with cows and antelopes.\r\nGoats live anywhere between 8–12 years.\r\nGoats DON'T have upper teeth.\r\nGoats are considered picky eaters and will sometimes reject food if it's dirty.\r\nIt’s believed that goats discovered coffee, as it was noticed they were energetic after consuming coffee beans.\r\n\r\n";
        Debug.Log("Goat Button clicked");
    }
}

