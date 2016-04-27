using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelSelect : MonoBehaviour {

	bool tutorialSelected = true;
	bool lvl1Selected = false;

	public GameObject tutorialText;
	public GameObject lvl1Text;

	// Use this for initialization
	void Start () {

		Text tutorial = tutorialText.GetComponent<Text>();
		tutorial.text = "Tutorial";

		Text lvl1 = lvl1Text.GetComponent<Text>();
		lvl1.text = "Level 1";

		tutorial.color = new Color (1f, 0f, 0f);
		lvl1.color = new Color (0f, 0f, 0f);
		tutorialSelected = true;
		lvl1Selected = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		Text tutorial = tutorialText.GetComponent<Text>();
		tutorial.text = "Tutorial";

		Text lvl1 = lvl1Text.GetComponent<Text>();
		lvl1.text = "Level 1";

//		tutorial.color = new Color (0f, 0f, 0f);
//		lvl1.color = new Color (0f, 0f, 0f);

		if (Input.GetKeyDown (KeyCode.A)) {
			tutorial.color = new Color (1f, 0f, 0f);
			lvl1.color = new Color (0f, 0f, 0f);
			tutorialSelected = true;
			lvl1Selected = false;
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			tutorial.color = new Color (0f, 0f, 0f);
			lvl1.color = new Color (1f, 0f, 0f);
			tutorialSelected = false;
			lvl1Selected = true;
		}

		if (Input.GetKeyDown (KeyCode.Return) && tutorialSelected == true) {
			Application.LoadLevel ("Tutorial");
		}

		if (Input.GetKeyDown (KeyCode.Return) && lvl1Selected == true) {
			Application.LoadLevel ("Lvl1");
		}

	
	}
}
