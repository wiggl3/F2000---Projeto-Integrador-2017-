using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PERSONAGEM : MonoBehaviour {


	//public Vector3 posPlayer;
	Rigidbody rb;
	//public float vel;
	DATA dt;
	[SerializeField]AudioSource dialogo1;
	[SerializeField]Text gameplayTimer;
	[SerializeField]float timer;
	[SerializeField]int minutes;
	public bool podeMover = false;
    //int progress = 0;

	CAM see;


	// Use this for initialization
	void Awake()
	{
		dt = FindObjectOfType<DATA> ();
	}

	void Start () 
	{

		see = FindObjectOfType<CAM> ();

		rb = GetComponent<Rigidbody>();	

		if (dt.load == false && SceneManager.GetActiveScene().name=="CENA1") 
		{
			dialogo1.Play ();
		}

		if (dt.load == true) 
		{
			//SceneManager.LoadScene(DATA.cena);
			transform.position = new Vector3 (DATA.posX, DATA.posY, DATA.posZ);
		}

		gameplayTimer.text = gameplayTimer.ToString ();
	}

	// Update is called once per frame
	void Update () 
	{
		move ();

		timer += Time.deltaTime;

		if (timer >= 60) 
		{
			minutes++;
			timer =0;
		}
		gameplayTimer.text = minutes + ":" + timer.ToString ("f1");

		DATA.posX = transform.position.x;
		DATA.posY = transform.position.y;
		DATA.posZ = transform.position.z;
		//DATA.cena = SceneManager.LoadScene("cena");

		/*if (Input.GetKeyDown ("m")) 
		{
			SceneManager.LoadScene ("MenuInicial");
		}*/

		if (Input.GetKeyDown ("l")) 
		{
			Debug.Log("Salvou");
			PlayerPrefs.SetFloat ("PosX", DATA.posX);
			PlayerPrefs.SetFloat ("PosY", DATA.posY);
			PlayerPrefs.SetFloat ("PosZ", DATA.posZ);
			dt.cenaSalva = SceneManager.GetActiveScene ().name;
			PlayerPrefs.SetString ("Scene", dt.cenaSalva);
		}
	}

	void move()
	{

		if (podeMover == true) {

			see.camSee = true;

			if (Input.GetKey (KeyCode.W)) {
				transform.Translate (0, 0, 5 * Time.deltaTime);
				//rb.AddForce(transform.right * vel * Time.deltaTime);
			}

			if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.LeftShift)) {
				transform.Translate (0, 0, 10 * Time.deltaTime);
				//rb.AddForce(transform.right * vel * Time.deltaTime);
			}

			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (0, 0, -5 * Time.deltaTime);
				//rb.AddForce(transform.right * -vel * Time.deltaTime);
			}

			//transform.eulerAngles += new Vector3 (0, Input.GetAxisRaw ("Horizontal") * Time.deltaTime*130, 0);
		} 

		else
		{
			see.camSee = false;
		}
	}
		
}
