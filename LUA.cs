using UnityEngine;
using System.Collections;

public class LUA : MonoBehaviour {

	[SerializeField]
	Transform Terra;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (Terra.position, new Vector3(0,1,0), 0.05f);
	}
}
