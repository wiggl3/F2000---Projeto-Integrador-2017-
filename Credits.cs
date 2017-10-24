using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

	[SerializeField]Scrollbar names;
	[SerializeField]Button back;

	// Use this for initialization
	void Start () {
		back.onClick = new Button.ButtonClickedEvent();
		back.onClick.AddListener(() => BackToGame());
	}
	
	// Update is called once per frame
	void Update () 
	{
		names.value -= Time.deltaTime/9;
	}

	void BackToGame()
	{
		SceneManager.LoadScene ("MenuInicial");
	}

}
