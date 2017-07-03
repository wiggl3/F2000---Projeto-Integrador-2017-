using UnityEngine;
using System.Collections;

public class RADAR : MonoBehaviour {

	public Transform sonda;
	public enum Opcoes {camera, radar};
	public Opcoes selecionar;
	float rotacao = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		switch (selecionar) 
		{
		case Opcoes.camera:
			transform.position = new Vector3 (sonda.position.x, transform.position.y, sonda.position.z);
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, sonda.eulerAngles.y + rotacao, transform.eulerAngles.z);
		break;

		case Opcoes.radar:
			transform.position = new Vector3 (sonda.position.x, transform.position.y, sonda.position.z);
		break;
		}
		//ransform.position = new Vector3 (sonda.position.x, transform.position.y, sonda.position.z);
		//transform.Rotate (new Vector3 (transform.rotation.x, transform.rotation.y, sonda.rotation.z));
	}
}
