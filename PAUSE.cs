using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PAUSE : MonoBehaviour {

	[SerializeField]bool paused;
	[SerializeField]GameObject stop;
	[SerializeField]Button continue_, museum_, menu_, exit_;

	PERSONAGEM persona;
 
	// Use this for initialization
	void Start () 
	{
		persona = FindObjectOfType<PERSONAGEM> ();

		continue_.onClick = new Button.ButtonClickedEvent();
		continue_.onClick.AddListener(() => Continue());

		museum_.onClick = new Button.ButtonClickedEvent();
		museum_.onClick.AddListener(() => Museum());

		menu_.onClick = new Button.ButtonClickedEvent();
		menu_.onClick.AddListener(() => Menu());

		exit_.onClick = new Button.ButtonClickedEvent();
		exit_.onClick.AddListener(() => ExitGame());


	}
	
	// Update is called once per frame
	void Update () 
	{

		if (paused == true) 
		{
			Time.timeScale = 0;
			stop.SetActive (true);
			persona.podeMover = false;
		}

		if (paused == false)
		{
			Time.timeScale = 1;
			stop.SetActive (false);
			//persona.podeMover = true;
		}
	
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			paused =! paused;
		}
	}
		
	void Continue()
	{
		paused = false;
	}

	void Museum()
	{
		SceneManager.LoadScene ("MuseuTutorial");
	}

	void Menu()
	{
		SceneManager.LoadScene ("MenuInicial");
	}

	void ExitGame()
	{
		Application.Quit ();
	}
		
}
