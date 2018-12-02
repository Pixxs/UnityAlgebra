using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedTextMenu : MonoBehaviour {
    public bool mainMenu;
    public GameObject TitleText;
    public GameObject StartButton;
    public GameObject Dice;
	// Use this for initialization
	void Start () {
        if (mainMenu)
        {
            TitleText.GetComponent<TextMesh>().color = Color.HSVToRGB(0f, 0.7f, 1f);
            var initButtonColors = StartButton.GetComponent<Button>().colors;
            initButtonColors.normalColor = Color.HSVToRGB(0f, 0.7f, 1f);
            StartButton.GetComponent<Button>().colors = initButtonColors;
        }
        else
        {
            Dice.GetComponent<Image>().color = Color.HSVToRGB(0f, 0.7f, 1f);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (mainMenu)
        {
            var newColor = StartButton.GetComponent<Button>().colors;
            float newHue;
            float newJunk;
            Color.RGBToHSV(newColor.normalColor, out newHue, out newJunk, out newJunk);
            newHue = newHue + 0.001f;

            newColor.normalColor = Color.HSVToRGB(newHue, 0.7f, 1f);

            TitleText.GetComponent<TextMesh>().color = newColor.normalColor;
            StartButton.GetComponent<Button>().colors = newColor;
        }
        else
        {
            var oldColor = Dice.GetComponent<Image>().color;
            float newHue;
            float newJunk;
            Color.RGBToHSV(oldColor, out newHue, out newJunk, out newJunk);
            newHue = newHue + 0.0025f;
            Dice.GetComponent<Image>().color = Color.HSVToRGB(newHue, 0.7f, 1f);
        }
        
    }
}
