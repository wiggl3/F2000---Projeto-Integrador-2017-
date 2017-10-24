//Este script vai na camera
using System;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	[SerializeField] [Range(0, 100)] float sensibilidade = 100.0f;
	[SerializeField] float angulo = 80.0f;
	[SerializeField] Transform player;
	float rotY = 0.0f;
	float rotX = 0.0f;

	void Start()
	{
		Vector3 rot = transform.localRotation.eulerAngles;
		rotY = rot.y;
		rotX = rot.x;
		player.eulerAngles = new Vector3 (player.eulerAngles.x, transform.eulerAngles.y, player.eulerAngles.z);
		transform.position = new Vector3 (player.position.x, player.position.y + 0.9f, player.position.z);
	}

	void Update()
	{
		MouseMove();
		SetTransforms ();
	}

	void MouseMove()
	{
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = -Input.GetAxis("Mouse Y");
		rotY += mouseX * sensibilidade * Time.deltaTime;
		rotX += mouseY * sensibilidade * Time.deltaTime;
		rotX = Mathf.Clamp(rotX, -angulo, angulo);
		Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
		transform.rotation = localRotation;
	}

	void SetTransforms(){
		player.eulerAngles = new Vector3 (player.eulerAngles.x, transform.eulerAngles.y, player.eulerAngles.z);
		transform.position = new Vector3 (player.position.x, player.position.y + 0.9f, player.position.z);
	}
}
