using UnityEngine;
using System.Collections;

public class SONAR : MonoBehaviour {

	public LayerMask informa;//layer que e vista pelo raycast que vem abaixo
    public GameObject [] caution;//array que pega todas as informacoes da fase
    int i;//int para verificar o numero de objetos que contem informacao
	[Space(20)]
	public AudioSource bip; //som que o sonar faz

	// Use this for initialization
	void Awake()
	{
		caution = GameObject.FindGameObjectsWithTag("InfoSonar");//pegando todos  os objetos com a tag e jogando na array
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 100 * Time.deltaTime, 0));//mandando o raycast girar para verificar onde ha objetos

		RaycastHit hit;//hit do raycast para dizer ondeele colidiu
        if (Physics.Raycast (transform.position, transform.forward, out hit, 60, informa))//posicao do raycast, direcao para onde ele e criado, usando o hit para informar a posicao, distancia maxima que ele atinge, informanda a layer que deve ser encontrada
		{
			Debug.Log (hit.point);//debuga a posicao onde colidiu o raycast
			for (i = 0; i < caution.Length; i++) //conta quantos ha na array e, se o numero estiver dentro da mesma, faz com que apareca a imagem de aviso e toque o som
			{
				caution [i].SetActive (true);
				bip.Play();
			}

			Debug.DrawLine (transform.position, hit.point);//desenha a linha da posicao do raycast quando colide com algo
		} 

		else 
		{
			for (i = 0; i < caution.Length; i++) //se verificar e nao encontrar nenhum com a tag, torna a imagem de aviso falsa
			{
				caution [i].SetActive (false);
			}
		}
	}
}
