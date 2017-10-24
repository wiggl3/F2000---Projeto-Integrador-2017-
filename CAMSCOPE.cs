using UnityEngine;
using System.Collections;

public class CAMSCOPE : MonoBehaviour {
	
	[SerializeField]Camera scope; //camera do telescopio
	[SerializeField]GameObject scopeSome; 
	[SerializeField]GameObject CamPerson;//camera personagem
	[SerializeField]GameObject CamRadar;//camera do radar
	[SerializeField]GameObject scopeImage;
	public bool telescopio = false;


	PERSONAGEM persona;
	TUTORIAL tuto;

	// Use this for initialization
	void Start () {
		persona = FindObjectOfType<PERSONAGEM> ();
		tuto = FindObjectOfType<TUTORIAL> ();

		scopeSome.SetActive (false);
		CamPerson.SetActive (true);
	}
	
	// Update is called once per frame
	void LateUpdate () {

		if (telescopio == true) //se o telescopio é verdadeiro, só a camera dele funciona
		{
			CamPerson.SetActive (false);
			CamRadar.SetActive(false);
			scopeSome.SetActive(true);
			scopeImage.SetActive(false);
			persona.podeMover = false;
		}

		if (telescopio == false) 
		{
			CamPerson.SetActive (true);
			CamRadar.SetActive(true);
			scopeSome.SetActive(false);

			if (tuto.cont >= 3) 
			{
				persona.podeMover = true;
			}
		}

	}

	void OnTriggerStay(Collider other)//enquanto estiver dentro do range
	{
		
		if (other.gameObject.tag == "TutoScope") { //verifica a tag do objeto


			scopeImage.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))

			{
                telescopio = !telescopio;

			}
			//O MESMO PROCESSO ACONTECE COM TODAS AS INFOMACOES DENTRO DA VOID OnTriggerStay
		}
	}


	void OnTriggerExit(Collider other)//enquanto estiver dentro do range
	{
		
		if (other.gameObject.tag == "TutoScope") { //verifica a tag do objeto
			
			
			scopeImage.SetActive(false);
		
			//O MESMO PROCESSO ACONTECE COM TODAS AS INFOMACOES DENTRO DA VOID OnTriggerStay
		}
	}
}
	
