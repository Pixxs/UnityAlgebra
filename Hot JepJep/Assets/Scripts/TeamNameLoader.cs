using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeamNameLoader : MonoBehaviour {
	public Text Team1Text;
	public Text Team2Text;
	public Text Team3Text;
	public Text Team4Text;
	public Text Team5Text;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

				Team1Text.text= PlayerPrefs.GetString ("Team1NameSave");
				Team2Text.text= PlayerPrefs.GetString ("Team2NameSave");
				Team3Text.text= PlayerPrefs.GetString ("Team3NameSave");
				Team4Text.text= PlayerPrefs.GetString ("Team4NameSave");
				Team5Text.text= PlayerPrefs.GetString ("Team5NameSave");
			}
	}
