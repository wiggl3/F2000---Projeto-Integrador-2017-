using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class SONDA : MonoBehaviour {


	public Transform [] MeshRodas;
	public WheelCollider[] ColisorRodas;
	public float torque = 1000, pesoVeiculo = 1500;
	private float angulo, direcao;

	Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();	

		rb.mass = pesoVeiculo;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		direcao = Input.GetAxis ("Horizontal");

		if (Input.GetAxis ("Horizaontal") > 0.7f || Input.GetAxis ("Horizaontal") < -0.7f)
			angulo = Mathf.Lerp (angulo, direcao, Time.deltaTime * 4);
		else 
		{
			angulo = Mathf.Lerp (angulo, direcao, Time.deltaTime * 2);
		}

	}

	void FixedUpdate()
	{
		ColisorRodas [0].steerAngle = angulo*40;
		ColisorRodas [1].steerAngle = angulo*40;

		ColisorRodas [2].motorTorque = Input.GetAxis("Vertical")*torque;
		ColisorRodas [3].motorTorque = Input.GetAxis("Vertical")*torque;

		for (int x = 0; x < ColisorRodas.Length; x++) 
		{
			Quaternion quat;
			Vector3 pos;
			ColisorRodas [x].GetWorldPose (out pos, out quat);
			MeshRodas [x].position = pos;
			MeshRodas [x].rotation = quat;
		}
	}
}
