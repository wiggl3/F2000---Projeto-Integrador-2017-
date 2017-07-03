using UnityEngine;
using System.Collections;

public class SCOPE : MonoBehaviour {
	
	[SerializeField]Camera scopinho;
	[SerializeField] private GameObject target;
	[SerializeField] private float rotSpeed;
	Vector3 offset;
	
	// Use this for initialization
	void Start () {
		scopinho.GetComponent<Camera> ().fieldOfView = 60;
		
		offset = target.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		
		Zoom ();

		float horizontal = Input.GetAxis ("Mouse X") * rotSpeed;
		target.transform.Rotate (0, horizontal, 0);
		
		float desitedAngle = target.transform.eulerAngles.x;
		Quaternion rotation = Quaternion.Euler (0, desitedAngle, 0);
		transform.position = target.transform.position - (rotation * offset);
		
		float vertical = -Input.GetAxis ("Mouse Y") * rotSpeed;
		transform.Rotate (vertical, 0, 0);
		
		float desitedAngle1 = target.transform.eulerAngles.y;
		Quaternion rotation1 = Quaternion.Euler (0, 0, desitedAngle1);
		transform.position = target.transform.position - (rotation1 * offset);
		
		//transform.LookAt(target.transform.position);

	}
	
	void Zoom ()
	{
		if (/*Input.GetAxis ("Mouse ScrollWheel") > 0 || */Input.GetMouseButton (1)) { //quando pressiona o botao direito do mouse
			scopinho.fieldOfView--; //diminui o campo de visao da camera
			
			if (scopinho.fieldOfView <= 30) { //se o campo de visao for igual ou maior que 30, se torna igual a 30
				scopinho.fieldOfView = 30;
			}
		}
		
		else
		{
			scopinho.fieldOfView++;
			
			if (scopinho.fieldOfView >= 60)
			{
				scopinho.fieldOfView = 60; //campo de visao igual a 60
			}
		}
		
	}
}
