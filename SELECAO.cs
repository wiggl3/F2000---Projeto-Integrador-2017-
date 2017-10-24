using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SELECAO : MonoBehaviour {

	[SerializeField]
	Transform[] planetsCam;
	[SerializeField]
	GameObject [] planets;
	[SerializeField]
	GameObject moldura;
	[SerializeField]
	GameObject fundo;
	[SerializeField]
	Button playLua, information;
	[SerializeField]Text planetName;

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

		information.onClick = new Button.ButtonClickedEvent ();
		information.onClick.AddListener (() => Informations());

		planetName.text = planetName.ToString ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow)) 
		{
			posicao++;
			if(posicao > 7)
				posicao = 0;
		}

		if (Input.GetKeyDown(KeyCode.LeftArrow)) 
		{
			posicao--;
			if(posicao < 0)
				posicao = 7;
		}

		if (posicao == 0)
		{
			planetName.text = "Mercúrio";
		} 


		else if (posicao == 1)
		{
			planetName.text = "Venus";
		} 

		else if (posicao == 2)
		{
			planetName.text = "Terra (Lua)";
		} 

		else if (posicao == 3)
		{
			planetName.text = "Marte";
		}

		else if (posicao == 4)
		{
			planetName.text = "Jupiter";
		}

		else if (posicao == 5)
		{
			planetName.text = "Sarturno";
		}

		else if (posicao == 6)
		{
			planetName.text = "Urano";
		}

		else if (posicao == 7)
		{
			planetName.text = "Netuno";
		}

		moldura.transform.position = Vector3.Slerp(moldura.transform.position, planetsCam[posicao].position, 5*Time.deltaTime);
	}

	void playMoon()
	{
		if (posicao == 2)
		{
			SceneManager.LoadScene ("Loading 1");
		}
	}

	void Informations()
	{

		if (posicao == 2) 
		{
			fundo.SetActive (true);
		}
	}
}
