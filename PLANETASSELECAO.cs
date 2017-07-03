using UnityEngine;
using System.Collections;

public class PLANETASSELECAO : MonoBehaviour {
	[SerializeField]
	enum planeta {mercurio, venus, terra, marte, jupiter, saturno, urano, netuno};
	[SerializeField]
	planeta vel;
	//public int vel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		switch (vel) 
		{
		case planeta.mercurio:
			transform.eulerAngles += new Vector3 (0, 10 * Time.deltaTime, 0);
				break;

		case planeta.venus:
			transform.eulerAngles += new Vector3 (0, 4 * Time.deltaTime, 0);
			break;

		case planeta.terra:
			transform.eulerAngles += new Vector3 (0, 6 * Time.deltaTime, 0);
			break;

		case planeta.marte:
			transform.eulerAngles += new Vector3 (0, 8 * Time.deltaTime, 0);
			break;

		case planeta.jupiter:
			transform.eulerAngles += new Vector3 (0, 10 * Time.deltaTime, 0);
			break;

		case planeta.saturno:
			transform.eulerAngles += new Vector3 (0, 4 * Time.deltaTime, 0);
			break;

		case planeta.urano:
			transform.eulerAngles += new Vector3 (0, 10 * Time.deltaTime, 0);
			break;

		case planeta.netuno:
			transform.eulerAngles += new Vector3 (0, 6 * Time.deltaTime, 0);
			break;

		}
	}
}
