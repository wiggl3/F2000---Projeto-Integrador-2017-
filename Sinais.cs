using UnityEngine;
using System.Collections;

public class Sinais : MonoBehaviour {

	SpriteRenderer changeColor;
	bool vaiSatanas = false;

	// Use this for initialization
	void Start ()
	{
		changeColor = GetComponentInChildren<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (vaiSatanas == true) 
		{
			changeColor.color = Color.red;
		}
	}

	void OnTriggerStay (Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			if (Input.GetKeyDown (KeyCode.E)) 
			{
				vaiSatanas = true;
			}
		}
	}
}
