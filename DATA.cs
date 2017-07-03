using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DATA : MonoBehaviour {

	private GameObject[] Datas;
	public static float posX, posY, posZ;
	//public string nomeCena;
	public string cenaSalva;
	public bool load = false;
	PERSONAGEM persona;

	void Awake()
	{
		//nomeCena = SceneManager.GetActiveScene ().name;
		persona = FindObjectOfType<PERSONAGEM> ();
		Datas = GameObject.FindGameObjectsWithTag ("DATA");
		if (Datas.Length >= 2) 
		{
			Destroy (Datas [0]);
		}
		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start () {

		//salvando a posição do personagem para o load

		//---------- posicao x ------------
		if (PlayerPrefs.HasKey ("PosX")) 
		{
			posX = PlayerPrefs.GetFloat ("PosX");
		} 
		else 
		{
			PlayerPrefs.SetFloat ("PosX", posX);
		}
		//-----------posicao y ------------
		if (PlayerPrefs.HasKey ("PosY")) 
		{
			posY = PlayerPrefs.GetFloat ("PosY");
		} 
		else 
		{
			PlayerPrefs.SetFloat ("PosY", posY);
		}
		//----------- posicao z -----------

		if (PlayerPrefs.HasKey ("PosZ")) 
		{
			posZ = PlayerPrefs.GetFloat("PosZ");
		} 
		else 
		{
			PlayerPrefs.SetFloat ("PosZ", posZ);
		}
		//------------ cena ---------------
		if (PlayerPrefs.HasKey ("Scene")) 
		{
			cenaSalva = PlayerPrefs.GetString("Scene");
		} 
		else 
		{
			PlayerPrefs.SetString ("Scene", cenaSalva);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

		
}
