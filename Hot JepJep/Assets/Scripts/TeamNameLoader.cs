using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeamNameLoader : MonoBehaviour {

	public string Team1Name;
	public string Team2Name;
	public string Team3Name;
	public string Team4Name;
	public string Team5Name;
	public Text Team1;
	public Text Team2;
	public Text Team3;
	public Text Team4;
	public Text Team5;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

				Team1Name = PlayerPrefs.GetString ("Team1NameSave");
				Team2Name = PlayerPrefs.GetString ("Team2NameSave");
				Team3Name = PlayerPrefs.GetString ("Team3NameSave");
				Team4Name = PlayerPrefs.GetString ("Team4NameSave");
				Team5Name = PlayerPrefs.GetString ("Team5NameSave");
				Team1.text = Team1Name;
				Team2.text = Team2Name;
				Team3.text = Team3Name;
				Team4.text = Team4Name;
				Team5.text = Team5Name;
			}
	}
