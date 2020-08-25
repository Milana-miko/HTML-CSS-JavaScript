using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour {

	public int Ins_speed;
	public GameObject settings;
	public Transform Player1;
	public Dropdown Game_Difficulty;



	void Start (){
		Global.Game_Difficulty = 2;
	}
	public void Load () {
		var xml = new XmlSerializer (typeof(Saveclass));
		var SC = new Saveclass ();
		SC.Hearts = 3;
		SC.Player1_Pos[Global.level1] = new Vector3 (0.37f, 3f, -3.16f);
		if (!Directory.Exists (Application.dataPath + "/save"))
			Directory.CreateDirectory (Application.dataPath + "/save");
		using (var stream = new FileStream (Application.dataPath + "/save/saver.xml", FileMode.Create, FileAccess.Write)) {
			xml.Serialize (stream, SC);
		}
		LoadGame ();
	}

	public void LoadGame () {
		SceneManager.LoadScene("level1");
	}




	public void Settings () {
		settings.SetActive (!settings.activeSelf);
	}

	public void ExitGame () {
		Application.Quit ();
	}

	public void _Game_Difficulty () {

		switch (Game_Difficulty.value) {
		case 1:
			Global.Game_Difficulty = 4;
			break;
		case 2: 
			Global.Game_Difficulty = 6;
			break;
		case 3: 
			Global.Game_Difficulty = 8;
			break;

		} 

	}

}
