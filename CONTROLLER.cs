using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CONTROLLER : MonoBehaviour {

	public int cont = 0;
	public string next;
	public string after;

	// Use this for initialization
	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		after = SceneManager.GetActiveScene().name.ToString();

		if (next != after) 
		{
			cont += 1;
			next = after;
		}

	}
}
