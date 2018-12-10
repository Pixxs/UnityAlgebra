using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StealBehaviour : MonoBehaviour {
	public GameObject TeamNameLoader;
	public GameObject TeamNameText;
	public GameObject Slider;
	public GameObject Dice;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Slider.GetComponent<Slider>().value == Dice.GetComponent<Dice>().CurrentTurn){
			TeamNameText.GetComponent<Text>().text = "Yourself\n????\nwhy though?";
		}
		else if(Slider.GetComponent<Slider>().value == 1){
			TeamNameText.GetComponent<Text>().text = TeamNameLoader.GetComponent<TeamNameLoader>().Team1Text.text;
		}
		else if(Slider.GetComponent<Slider>().value == 2){
			TeamNameText.GetComponent<Text>().text = TeamNameLoader.GetComponent<TeamNameLoader>().Team2Text.text;
		}
		else if(Slider.GetComponent<Slider>().value == 3){
			TeamNameText.GetComponent<Text>().text = TeamNameLoader.GetComponent<TeamNameLoader>().Team3Text.text;
		}
		else if(Slider.GetComponent<Slider>().value == 4){
			TeamNameText.GetComponent<Text>().text = TeamNameLoader.GetComponent<TeamNameLoader>().Team4Text.text;
		}
		else if(Slider.GetComponent<Slider>().value == 5){
			TeamNameText.GetComponent<Text>().text = TeamNameLoader.GetComponent<TeamNameLoader>().Team5Text.text;
		}
	}
}
