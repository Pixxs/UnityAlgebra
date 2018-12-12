using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceAnimation : MonoBehaviour {
	public Sprite PressedImage;
	public Sprite DefaultImage;
	public bool Pressed;

	public GameObject DiceText;
	public GameObject Dice;
	// Use this for initialization
	void Start () {
		StartCoroutine(animateDice());
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(DiceText.GetComponent<RectTransform>().anchoredPosition);
	}
	IEnumerator animateDice()
	{
		while(true){
			if((Pressed || Dice.GetComponent<Dice>().Active == false) &&  Dice.GetComponent<Dice>().Rolling == false){
				GetComponent<Image>().sprite = DefaultImage;
				DiceText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f,-165.5f);
				Pressed = false;
			}
			else{
				GetComponent<Image>().sprite = PressedImage;
				DiceText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f,-170.5f);
				Pressed = true;
			}
			yield return new WaitForSeconds(0.5f);
		}
	}
}
