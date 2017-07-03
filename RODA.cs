using UnityEngine;
using System.Collections;

public class RODA : MonoBehaviour {

    //Rigidbody rb;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate (new Vector3(0, 50 * Time.deltaTime, 0));
            //transform.Translate (new Vector3 (0, 5 * Time.deltaTime, 0));
        }
	}
}
