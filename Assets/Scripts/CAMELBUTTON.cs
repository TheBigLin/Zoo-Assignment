using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CAMELBUTTON : MonoBehaviour
{
    [SerializeField]
    Button cambtn;

    [SerializeField]
    TMP_Text txt;

    void Start()
    {
        cambtn.onClick.AddListener(ButtonTest);
    }

    void ButtonTest()
    {
        txt.text = "FUN FACTS ABOUT CAMELS!\r\nThere’s actually more than 160 words for camel in Arabic.\r\nCamels can live up to 50 years, despite being born without humps at all.\r\nThe meat of a camel is considered a delicacy.\r\nLlamas and camels are actually cousins\r\nThe most expensive camel ever sold was sold for $53 million USD in 2019!\r\nCamels store water in their blood\r\nThey also store fat in their humps for energy\r\nCamels may seem slow, but this would be incorrect, as they can run up to 40mph!\r\n\r\n";
        Debug.Log("Button clicked");
    }
}