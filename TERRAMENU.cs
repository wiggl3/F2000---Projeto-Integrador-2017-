using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TERRAMENU : MonoBehaviour {

	float vel;
	public Transform lua;
	public int scene;

    [SerializeField]
    GameObject nuvens;


	// Use this for initialization
	void Start () {
		vel = 1;
		//RenderSettings.fog = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (scene == 0) 
		{
			transform.eulerAngles += new Vector3 (0, 10 * Time.deltaTime, 0);
		}

		if (scene == 1) 
		{
			transform.RotateAround (lua.position,new Vector3 (0,3,0), vel * Time.deltaTime);
			transform.eulerAngles += new Vector3 (0, 1 * Time.deltaTime, 0);
		}
	}

	void move ()
	{
		
	}
}
