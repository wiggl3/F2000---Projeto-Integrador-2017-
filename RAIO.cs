using UnityEngine;
using System.Collections;

public class RAIO : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward,out hit, 10)) 
		{
			//Debug.Log (hit.point);
			Debug.DrawLine (transform.position,hit.point);
		}
	}
}
