using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SELECAO : MonoBehaviour {

	[SerializeField]
	Transform[] planetsCam;
	[Space(20)]
	[SerializeField]
	GameObject [] planets;
	[Space(20)]
	[SerializeField]
	GameObject moldura;
	[Space(20)]
	[SerializeField]
	GameObject fundo;
	[Space(20)]
	[SerializeField]
	Button playLua;

	public int posicao = 0;
	int quant;

	// Use this for initialization
	void Start () {
		//quant = planetsCam.Length - 1;
		planets [0].GetComponent<MeshRenderer> ().material.color = Color.black;
		planets [1].GetComponent<MeshRenderer> ().material.color = Color.black;
		planets [3].GetComponent<MeshRenderer> ().material.color = Color.black;
		planets [4].GetComponent<MeshRenderer> ().material.color = Color.black;
		planets [5].GetComponent<MeshRenderer> ().material.color = Color.black;
		planets [6].GetComponent<MeshRenderer> ().material.color = Color.black;
		planets [7].GetComponent<MeshRenderer> ().material.color = Color.black;

		playLua.onClick = new Button.ButtonClickedEvent ();
		playLua.onClick.AddListener (() => playMoon());

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.D)) 
		{
			posicao++;
			if(posicao > 7)
				posicao = 0;
		}

		if (Input.GetKeyDown(KeyCode.A)) 
		{
			posicao--;
			if(posicao < 0)
				posicao = 7;
		}

		if (posicao == 2 && Input.GetKey(KeyCode.Return)) {
			fundo.SetActive (true);
		} 

		moldura.transform.position = Vector3.Slerp(moldura.transform.position, planetsCam[posicao].position, 5*Time.deltaTime);
	}

	void playMoon()
	{
		SceneManager.LoadScene("Loading");
	}
}
