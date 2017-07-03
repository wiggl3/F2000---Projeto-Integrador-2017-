using UnityEngine;
using System.Collections;

public class ANIMACAOMENU : MonoBehaviour {


	[SerializeField]
	enum load {roda1, roda2, roda3, roda4, roda5, roda6, roda7, roda8};  //enum com todos os planetas 
	[SerializeField] load girar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		switch (girar) 
		{
		case load.roda1:
				transform.Rotate (new Vector3 (0, 0, 1.3f *100* Time.deltaTime));//velocidade de rotação dos planetas
			break;

		case load.roda2:
			transform.Rotate (new Vector3 (0, 0, -1.2f *100* Time.deltaTime));
			break;

		case load.roda3:
			transform.Rotate (new Vector3 (0, 0, 1.4f *100* Time.deltaTime));
			break;

		case load.roda4:
			transform.Rotate (new Vector3 (0, 0, 1.2f *100* Time.deltaTime));
			break;

		case load.roda5:
			transform.Rotate (new Vector3 (0, 0, 1.7f *100* Time.deltaTime));
			break;

		case load.roda6:
			transform.Rotate (new Vector3 (0, 0, 1.6f *100* Time.deltaTime));
			break;

		case load.roda7:
			transform.Rotate (new Vector3 (0, 0, 1.1f *100* Time.deltaTime));
			break;

		case load.roda8:
			transform.Rotate (new Vector3 (0, 0, 1.5f *100* Time.deltaTime));
			break;
			   
		}
	}

}
