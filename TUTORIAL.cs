using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TUTORIAL : MonoBehaviour {

	[SerializeField]
	GameObject mouse;

	[SerializeField]
	GameObject teclas;

	[SerializeField]
	GameObject fotos;

	[SerializeField]
	Button ok;

	[SerializeField]
	GameObject painel;

	public int cont;

	[SerializeField] 
	Text informa, nomeObjeto; //texto onde aparecem as informacoes e texto que diz qual o objeto encontrado

	[Space(20)]
	[SerializeField] 
	GameObject fundo;//pop-up das informacoes

	[Space(20)]
	[SerializeField]
	GameObject exclama;//aviso de que ali ha alguma informacao

	[Space(20)]
	[SerializeField]
	Toggle [] objetivos;

	[Space(20)]
	[SerializeField] 
	AudioSource [] falas,falasRef,falasMuseu;

	[Space(20)]
	bool tocando = false;

	[Space(20)]
	float tempo=0,contaFala=0;
	int i=0;

	PERSONAGEM persona;
	CAMSCOPE cam;

	[SerializeField]
	ScrollRect barra;

	// Use this for initialization
	void Start () {
		persona = FindObjectOfType<PERSONAGEM> ();
		cam = FindObjectOfType<CAMSCOPE> ();

		ok.onClick = new Button.ButtonClickedEvent();
		ok.onClick.AddListener(() => OkButton());
		mouse.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {


		if (cont >= 1) 
		{
			mouse.SetActive(false);
			teclas.SetActive(true);
			fotos.SetActive (false);
		}

		if (cont >= 2) 
		{
			mouse.SetActive(false);
			teclas.SetActive(false);
			fotos.SetActive (true);
		}

		if (cont >= 3) 
		{
			painel.SetActive(false);
			persona.podeMover = true;
		}

		if (Input.GetKey(KeyCode.Return)) 
		{
			SceneManager.LoadScene("CENA");
		}
		
	}

	void OkButton ()
	{
		cont += 1;
	}

	void OnTriggerExit(Collider other)//enquanto estiver dentro do range
	{
		//-----------TUTO-------------
		

		if (other.gameObject.tag == "TutoScope")
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
			objetivos[0].isOn = true;
		}
			
		if (other.gameObject.tag == "TutoAster") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoIkaros") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoMessenger") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoLuna9")
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoSurveyor") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoHorizons") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoHubble")
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);

		}
		if (other.gameObject.tag == "TutoWebb") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);

		}
		if (other.gameObject.tag == "TutoKepler") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);

		}
		if (other.gameObject.tag == "TutoDawn") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoVoyager")
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoAkatsuki") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoSpirit") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoGal") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);

		}
		if (other.gameObject.tag == "TutoSat") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}
		if (other.gameObject.tag == "TutoCurio") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);
		}

		if (other.gameObject.tag == "TutoAstro") 
		{
			exclama.SetActive (false); 
			fundo.SetActive (false);

		}

	}


	void OnTriggerStay(Collider other)//enquanto estiver dentro do range
	{
		//-----------TUTO-------------

		if (other.gameObject.tag == "TutoScope") 
		{
			exclama.SetActive (false); 
		}

		if (other.gameObject.tag == "TutoScreen") 
		{
			exclama.SetActive (false); 
			objetivos[6].isOn = true;
		}


		if (other.gameObject.tag == "TutoAster") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Meteorito Bendegó";
				informa.text = "Fragmento do meteorito de Bendegó. Um meteorito encontrado no Brasil, sendo o maior siderito (meteoritos cuja composição é predominantemente níquel e ferro) já encontrado no país. O meteorito original pesa mais de 5 toneladas.";
				fundo.SetActive (true);
			}
		}

		if (other.gameObject.tag == "TutoAstro") {
			exclama.SetActive (true); 

			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				objetivos[3].isOn = true;
				nomeObjeto.text = "Roupa Esopacial de Armstrong";
				informa.text = "Representação do uniforme utilizado por Armstrong na espedição Apollo 11, a primeira a levar o homem em segurança até a Lua";
				fundo.SetActive (true);
			}
		}

		if (other.gameObject.tag == "TutoIkaros") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Ikaros";
				informa.text = "Representação da sonda IKAROS, uma sonda interplanetária japonesa que tem como objetivo demonstrar a tecnologia das “velas solares” em espaço interplanetário. É a primeira nave a demonstrar com sucesso o uso dessa tecnologia fora do planeta Terra que, basicamente, consiste em utilizar a pressão da radiação para gerar aceleração. ";
				if (falasMuseu [0].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [0].clip.length;
					falasMuseu [0].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoMessenger") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Messenger";
				informa.text = "Representação da Messenger, uma sonda espacial destinada a estudar as características de Mercúrio. Dentre os diversos dados colhidos, algumas das descobertas da sonda foram a composição da superfície do planeta, sua história geológica, e que seus depósitos polares são, na maioria, compostos por gelo.";
				if (falasMuseu [1].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [1].clip.length;
					falasMuseu [1].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoLuna9") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Luna 09";
				informa.text = "Representação da Luna 9, primeira espaçonave a conseguir um pouso suave na Lua e transmitir os dados de sua superfície para a Terra. Foi lançada em 31 de Janeiro de 1966.";
				if (falasMuseu [2].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [2].clip.length;
					falasMuseu [2].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoSurveyor") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Surveyor 1";
				informa.text = "Representação da Surveyor 1, a primeira espaçonave americana a pousar em segurança na superfície lunar. Foi lançada em 30 de maio de 1966 e permaneceu funcionando por 65 horas após pousar na Lua.";
				if (falasMuseu [3].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [3].clip.length;
					falasMuseu [3].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoHorizons") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "NewHorizons";
				informa.text = "Representação da New Horizons, uma sonda não tripulada da NASA, cujo objeto é estudar o planeta-anão Plutão e o cinturão de Kepler. Foi a primeira espaçonave a sobrevoar Plutão e fotografar suas pequenas luas: Caronte, Nix, Hydra, Cérbero e Estige.";
				if (falasMuseu [4].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [4].clip.length;
					falasMuseu [4].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoHubble") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				objetivos[2].isOn = true;
				nomeObjeto.text = "Telescópio Hubble";
				informa.text = "Representação do Telescópio Espacial Hubble, um dos mais importantes telescópios da história da humanidade. Ele fica no espaço, longe da atmosfera terrestre, o que permite que ele consiga imagens precisas de lugares distantes no universo. Seu nome é uma homenagem à Edwin Powell Hubble, o homem que constatou que o universo estava se expandindo.";
				if (falasMuseu [5].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [5].clip.length;
					falasMuseu [5].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoWebb") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				objetivos[4].isOn = true;
				nomeObjeto.text = "Telescópio James Webb";
				informa.text = "Representação do Telescópio Espacial James Webb. É o “sucessor” do telescópio Hubble, além de ser muito mais potente que o mesmo. Sua órbita final é no ponto de Lagrange L2, um ponto além da órbita da Lua, o que torna impossível a manutenção do telescópio, uma vez que é bem distante do ônibus espacial, consequentemente, seu tempo de vida útil é bem menor se comparado ao Hubble. Seu nome é uma homenagem à James Edwin Webb, um antigo administrador da agência espacial americana e que liderou o programa Apollo.";
				if (falasMuseu [6].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [6].clip.length;
					falasMuseu [6].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoKepler") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				objetivos[5].isOn = true;
				nomeObjeto.text = "Kepler";
				informa.text = "Representação da sonda Kepler, um observatório espacial projetado pela NASA, cuja missão é procurar por planetas extra-solares. O telescópio foi responsável pela descoberta de diversos planetas, dentre eles: Kepler 10b, Kepler 16b, Kepler 22b e Kepler 20. A sonda teve problemas em seu problema de giroscópio e, consequentemente, não opera mais em sua função primária.";
				if (falasMuseu [7].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [7].clip.length;
					falasMuseu [7].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoDawn") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Dawn";
				informa.text = "Representação da Sonda Dawn, desenvolvida pela NASA, como parte do projeto Discovery. A sonda tem como objetivo explorar os planetas anões: Ceres e Vesta, presentes no cinturão de asteroides que localiza-se entre Marte e Júpiter. Entrou em órbita com Ceres em 6 de março de 2015.";
				if (falasMuseu [8].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [8].clip.length;
					falasMuseu [8].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoVoyager") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Voyager 1";
				informa.text = "Representação da Voyager 1, uma sonda espacial Americana, cuja missão era explorar Júpiter e Saturno. Lançada em 1977, a sonda alcançou o espaço interestelar, tornando-se o primeiro artefato construído por humanos a realizar tal feito, atualmente a sonda encontra-se além das fronteiras do sistema Solar.";
				if (falasMuseu [9].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [9].clip.length;
					falasMuseu [9].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoAkatsuki") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Akatsuki";
				informa.text = "Representação da Akatsuki, uma sonda japonesa com missão de explorar Vênus. A sonda falhou em entrar na órbita do planeta, em 2010, devido a problemas de propulsão.  Apenas após cinco anos de tentativas a sonda conseguiu entrar na órbita de Vênus com sucesso.";
				if (falasMuseu [10].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [10].clip.length;
					falasMuseu [10].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoSpirit") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Spirit Rover";
				informa.text = "Representação do Rover Spirit, um veículo que percorreu a atmosfera de Marte, coletando informações. O robô permaneceu ativo por mais de vinte vezes o tempo inicial estimado, além de ter percorrido mais de 7 km, ao invés dos 1 km estipulados no início da missão. Em 2010 a comunicação com a sonda foi cortada totalmente e sua missão teve fim, sendo considerada uma das mais bem sucedidas missões da NASA. ";
				if (falasMuseu [11].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [11].clip.length;
					falasMuseu [11].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoGal") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				objetivos[1].isOn = true;
				nomeObjeto.text = "Telescópio de Galileu";
				informa.text = "Representação do Telescópio de Galileu, um telescópio que revolucionou a astronomia. Apesar de não ter sido o primeiro telescópio, era muito mais potente que qualquer aparelho de sua época, permitindo a Galileu realizar diversas descobertas, como a presença de crateras na Lua e que a Terra não era o centro do Universo.";
				if (falasMuseu [12].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [12].clip.length;
					falasMuseu [12].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoSat") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Satélite";
				informa.text = "Representação de um satélite artificial, ou seja, um corpo feito pelo homem e colocado em órbita com a Terra ou outro corpo celeste. Diversos desses satélites orbitam a Terra, sendo sua maioria destinados a telecomunicações.";
				if (falasMuseu [13].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [13].clip.length;
					falasMuseu [13].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
		if (other.gameObject.tag == "TutoCurio") {
			exclama.SetActive (true); 
			
			if (Input.GetKeyDown (KeyCode.E)) {
				barra.verticalNormalizedPosition = 1;
				nomeObjeto.text = "Curiosity Rover";
				informa.text = "Representação do Rover Curiosity, um veículo que explora a atmosfera de Marte, em busca de evidências sobre o planeta ser ou ter sido um dia capaz de habitar vida, além de aprender informações sobre a superfície do gigante vermelho. Foi lançado em 2011, como parte da missão Mars Science Laboratory.";
				if (falasMuseu [14].isPlaying && tocando == false) {
					tocando = true;
				} else if (tocando == false) {
					tempo = falasMuseu [14].clip.length;
					falasMuseu [14].Play ();
					tocando = true;
					contaFala = 0;
					Invoke ("trocaTocando", tempo);
				}
				fundo.SetActive (true);
			}
		}
	}
	void trocaTocando(){
		tocando = false;
		contaFala=0;
	}
}
