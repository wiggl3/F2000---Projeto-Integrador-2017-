using UnityEngine;
using System.Collections;

public class CAM : MonoBehaviour {

	[SerializeField]Camera personaCam;
	[SerializeField] private GameObject target;
	private float rotSpeed = 5;
	public bool camSee = false;
	Vector3 offset;

	// Use this for initialization
	void Start () {
		personaCam.GetComponent<Camera> ().fieldOfView = 60; //pegando o zoom da camera

		offset = target.transform.position - transform.position; //objeto que deve ser seguido
	}
	
	// Update is called once per frame
	void LateUpdate () {

		Zoom ();

		if (camSee == true) 
		{
			float horizontal = Input.GetAxis ("Mouse X") * rotSpeed;
			target.transform.Rotate (0, horizontal, 0);

			float desitedAngle = target.transform.eulerAngles.y;
			Quaternion rotation = Quaternion.Euler (0, desitedAngle, 0);
			transform.position = target.transform.position - (rotation * offset);

			float vertical = -Input.GetAxis ("Mouse Y") * rotSpeed;
			transform.Rotate (vertical, 0, 0);
			
			float desitedAngle1 = target.transform.eulerAngles.y;
			Quaternion rotation1 = Quaternion.Euler (0, 0, desitedAngle1);
			transform.position = target.transform.position - (rotation * offset);
		}

		if (Time.timeScale == 0) 
		{
			rotSpeed = 0;
		}

		else
		{
			rotSpeed = 5;
		}

		//transform.LookAt(target.transform.position);
	}

	void Zoom ()
	{
		if (/*Input.GetAxis ("Mouse ScrollWheel") > 0 || */Input.GetMouseButton (1)) { //quando pressiona o botao direito do mouse
			personaCam.fieldOfView--; //diminui o campo de visao da camera
			
			if (personaCam.fieldOfView <= 30) { //se o campo de visao for igual ou maior que 30, se torna igual a 30
				personaCam.fieldOfView = 30;
			}
		}
		
		else
		{
			personaCam.fieldOfView++;
			
			if (personaCam.fieldOfView >= 60)
			{
				personaCam.fieldOfView = 60; //campo de visao igual a 60
			}
		}
		
	}
}
