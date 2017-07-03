using UnityEngine;
using System.Collections;

public class SOL : MonoBehaviour {
	[SerializeField]
	Transform Marte;

	[SerializeField]
	Vector3 angle;

	[SerializeField]
	float axis;

	[SerializeField]
	Skybox ceu;
	// Use this for initialization
	void Start () {
//		ceu.GetComponent<Material>().;
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (Marte.position, angle, axis);
	}
}
