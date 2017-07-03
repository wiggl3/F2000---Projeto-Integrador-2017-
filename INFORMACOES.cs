using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class INFORMACOES : MonoBehaviour {

	//public GameObject [] textos;
	[SerializeField] 
	Text informa, nomeObjeto, nomeObjetivo; //texto onde aparecem as informacoes e texto que diz qual o objeto encontrado
	[Space(20)]
	[SerializeField] 
	GameObject fundo;//pop-up das informacoes
	[Space(20)]
	[SerializeField]
	GameObject exclama, objConcluido;//aviso de que ali ha alguma informacao
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
	public int cont = 0;
	int i=0;
	[SerializeField]
	AudioSource dialogoI;


	CAMSCOPE cam;


	// Use this for initialization
	void Start () {

		informa.text = informa.ToString();//conversao do texto para striing. assim ele pode ser mudado dentro do script
		informa.text = " ";//texto inicial, ou seja, no caso, texto vazio
		nomeObjeto.text = nomeObjeto.ToString ();
		nomeObjeto.text = " ";
		nomeObjetivo.text = nomeObjetivo.ToString ();
		nomeObjetivo.text = " ";
		RenderSettings.fog = false;
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (tocando);
		if(dialogoI.isPlaying){
			tocando=true;
			contaFala=0;
			tempo=dialogoI.clip.length;
			Invoke("trocaTocando",tempo);
		}

		contaFala+=Time.deltaTime;
		if(contaFala>=15.0f && tocando==false ){
			i=Random.Range(0,21);
			falasRef[i].Play();
			tocando=true;
			contaFala=0;
			tempo=falasRef[i].clip.length;
			Invoke ("trocaTocando",tempo);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Lua")
		{
			cont += 1;
			if (cont == 1)
			{
				falas[12].Play();
				tocando=true;
				contaFala=0;
				tempo=falas[12].clip.length;
				Invoke("trocaTocando",tempo);
			}
			RenderSettings.fog = true;
		}
	}

	void OnTriggerStay(Collider other)//enquanto estiver dentro do range
	{
		
		//-----------LUA--------------

		if (other.gameObject.tag == "Bandeira") 
		{
			exclama.SetActive (true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[0].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Bandeira Americana'' concluida!";
				nomeObjeto.text = "Bandeira Americana";
				informa.text = "Bandeira dos Estados Unidos. Além de um objeto que demonstra a chegada do homem à lua, seu simbolismo é muito maior. A bandeira é um símbolo da corrida espacial e, consequentemente da Guerra Fria. Onde duas potências hegemônicas disputavam frequentemente, eram estas: Os Estados Unidos e a URSS. Não resumindo apenas sua disputa a terra, começaram uma corrida para quem lançava o primeiro homem ao espaço, posteriormente à Lua. Essa disputa tinha um objetivo, a nação que possuísse a maior tecnologia para os foguetes consequentemente também teria para os mísseis, demostrando assim possuir um potencial bélico maior. Sendo assim, muito mais do que uma representação da chegada do homem à lua, a bandeira é uma afirmação de que esse primeiro homem foi um americano e não um soviético.";
				if(falas[0].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[0].clip.length;
					falas[0].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive (true);
			}
		}


		else if (other.gameObject.tag == "Pegada")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[1].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Pegada de Amstrong'' concluida!";
				nomeObjeto.text = "Pegada de Armstrong";
				informa.text = "''Um pequeno passo para um homem mas um gigantesco salto para a humanidade.'' – foi a frase que Neil Armstrong proferiu ao dar o primeiro passo na Lua. Apesar disso, a popular pegada não é dele, e sim do segundo homem a pisar na Lua: Buzz Aldrin.";
				if(falas[1].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[1].clip.length;
					falas[1].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
		}

		else if (other.gameObject.tag == "Surv1")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[2].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Surveyor 1'' concluida!";
				nomeObjeto.text = "Surveyor 1";
				informa.text = "Primeira espaçonave americana a pousar em segurança na superfície lunar. Retornou com sucesso 11.240 fotos e sobreviveu por dois dias lunares. O principal objetivo do programa Surveyor, como um todo, foi fornecer apoio às missões tripuladas que viram, do programa Apollo.";
				if(falas[2].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[2].clip.length;
					falas[2].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
		}

		else if (other.gameObject.tag == "Surv3")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[3].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Surveyor 3'' concluida!";
				nomeObjeto.text = "Surveyor 3";
				informa.text = "Foi a segunda espaçonave da série Surveyor a conseguir uma aterrisagem suave no solo lunar. Retornou mais de 6300 fotos para a Terra e seu braço robótico foi operado por mais de 18 horas, conseguindo cavar trincheiras de até 18cm. A Surveyor 3 também foi visitada pelos astronautas da missão Apollo 12, 2 anos depois.";
				if(falas[3].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[3].clip.length;
					falas[3].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
		}

		else if (other.gameObject.tag == "Surv5")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[4].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Surveyor 5'' concluida!";
				nomeObjeto.text = "Surveyor 5";
				informa.text = "Surveyor 5 foi a terceira nave espacial do projeto Surveyor que conseguiu um pouso bem sucedido na Lua e a primeira espaçonave a conseguir, de fato, obter dados da composição de um corpo extraterrestre. Transmitiu mais de 19.000 imagens para a Terra e operou por mais de 100 horas realizando a análise composicional da superfície.";
				if(falas[4].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[4].clip.length;
					falas[4].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
		}

		else if (other.gameObject.tag == "Surv6")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[5].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Surveyor 6'' concluida!";
				nomeObjeto.text = "Surveyor 6";
				informa.text = "Quarta espaçonave da série Surveyor a alcançar a superfície da lua em segurança. Pousou na região do Sinus Medii. A missão retornou um total de 29.952 imagens e adquiriu mais de 100 horas de análise da composição do material da superfície lunar.";
				if(falas[5].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[5].clip.length;
					falas[5].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
		}

		else if (other.gameObject.tag == "Surv7")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[6].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Surveyor 7'' concluida!";
				nomeObjeto.text = "Surveyor 7";
				informa.text = "Surveyor 7 foi a quinta e última nave espacial da série Surveyor a pousar em segurança na Lua. \n \n Além disso, foi a primeira espaçonave a pousar na região das Terras Altas (ou partes brancas). A missão foi um completo sucesso, retornando mais de 21.000 fotos e realizando mais de 100 horas de análise da superfície.";
				if(falas[6].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[6].clip.length;
					falas[6].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
		}

		else if (other.gameObject.tag == "Luna9")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[7].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Luna 9'' concluida!";
				nomeObjeto.text = "Luna 9";
				informa.text = "Luna 9 foi a primeira espaçonave a conseguir um pouso suave na Lua e transmitir dados de sua superfície para a Terra. Tendo sido lançada em 3 de Fevereiro de 1966, transmitiu seu último contato 3 dias depois, tendo enviado 9 fotos da superfície lunar antes disso. Incluindo 5 panoramas." ;
				if(falas[7].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[7].clip.length;
					falas[7].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
		}

		else if (other.gameObject.tag == "Luna13")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[8].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Luna 13'' concluida!";
				nomeObjeto.text = "Luna 13";
				informa.text = "Luna 13 foi a segunda espaçonave soviética a aterrissar com sucesso na superfície da Lua. Carregava um pequeno kit de instrumentos científicos, incluindo um acelerômetro e um radiômetro. Retornou um total de 5 panoramas da superfície Lunar, determinou a temperatura ao meio dia como sendo de 117ºC e determinou que os níveis de radiação não seriam tão perigosos para os humanos. Perdeu o contato em 28 de dezembro de 1966, com o esgotamento das baterias de bordo.";
				if(falas[8].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[8].clip.length;
					falas[8].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
		}

		else if (other.gameObject.tag == "RoverNasa")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[9].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Rover'' concluida!";
				nomeObjeto.text = "Veiculo espacial - Rover";
				informa.text = "Rover da Nasa.  carrinho que o luikson quer andar";
				if(falas[9].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[9].clip.length;
					falas[9].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
		}

		else if (other.gameObject.tag == "Cratera")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				objetivos[10].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Cratera'' concluida!";
				nomeObjeto.text = "Cratera";
				informa.text = "A lua não possuí uma atmosfera, logo, toda sua superfície é suscetível a impactos cósmicos e variações de temperatura. O que ocasiona diversas crateras, como essa";
				if(falas[10].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[10].clip.length;
					falas[10].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
		}

		else if (other.gameObject.tag == "Aitken") //verifica a tag do objeto
		{
			exclama.SetActive (true); //imagem que indica informacao aparece 

			if (Input.GetKeyDown (KeyCode.E))//se apertar i e estiver dentro do range o texto abaixo aparece
			{
				objetivos[11].isOn = true;
				objConcluido.SetActive(true);
				nomeObjetivo.text = "Missao ''Bacia Aitken'' concluida!";
				nomeObjeto.text = "Bacia Aitken";
				informa.text = "A maior cratera da Lua e uma das maiores de todo o Sistema Solar. Com aproximadamente 2500 Km de diâmetro e 13 Km de profundidade, é também a mais antiga e mais profunda depressão reconhecida na Lua. É quase que totalmente localizada no lado “negro” da Lua.";
				if(falas[11].isPlaying && tocando ==false){
					tocando=true;
				}
				else if(tocando==false){
					tempo = falas[11].clip.length;
					falas[11].Play();
					tocando=true;
					contaFala=0;
					Invoke ("trocaTocando",tempo);
				}
				fundo.SetActive(true);
			}
			//O MESMO PROCESSO ACONTECE COM TODAS AS INFOMACOES DENTRO DA VOID OnTriggerStay

		}

		else if (other.gameObject.tag == "Scope")
		{
			exclama.SetActive(true);

			if (Input.GetKeyDown (KeyCode.E))
			{
				nomeObjeto.text = "Telescopio Hubble";
				informa.text = "Telescopio Hubble";
				fundo.SetActive(true);
			}
		}



	}

	void OnTriggerExit(Collider other)//Quando sai de dentro do range de informacao
	{

		//-----------TUTO-------------
		if (other.gameObject.tag == "TutoTerra") //verifica qual a tag do objeto
		{
			fundo.SetActive (false);//pop-up se torna falso
			informa.text = " ";//texto volta a ser vazio
			nomeObjeto.text = " ";
			exclama.SetActive (false);//aviso de informacao se torna falso
		}

		if (other.gameObject.tag == "TutoAster") //verifica qual a tag do objeto
		{
			fundo.SetActive (false);//pop-up se torna falso
			informa.text = " ";//texto volta a ser vazio
			nomeObjeto.text = " ";
			exclama.SetActive (false);//aviso de informacao se torna falso
		}

		//-----------LUA--------------

		if (other.gameObject.tag == "Aitken") //verifica qual a tag do objeto
		{
			fundo.SetActive (false);//pop-up se torna falso
			objConcluido.SetActive(false);
			informa.text = " ";//texto volta a ser vazio
			nomeObjeto.text = " ";
			exclama.SetActive (false);//aviso de informacao se torna falso
		}

		//O MESMO PROCESSO ACONTECE COM TODAS AS INFOMACOES DENTRO DA VOID OnTriggerExit

		else if (other.gameObject.tag == "Bandeira") 
		{
			fundo.SetActive (false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive (false);

		}

		else if (other.gameObject.tag == "Sonda")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);

		}

		else if (other.gameObject.tag == "Cratera")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);

		}

		else if (other.gameObject.tag == "RoverNasa")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);

		}

		else if (other.gameObject.tag == "Scope")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);

		}

		else if (other.gameObject.tag == "Surv1")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);
		}

		else if (other.gameObject.tag == "Surv3")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);
		}

		else if (other.gameObject.tag == "Surv5")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);
		}

		else if (other.gameObject.tag == "Surv6")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);
		}

		else if (other.gameObject.tag == "Surv7")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);
		}

		else if (other.gameObject.tag == "Pegada")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);
		}

		else if (other.gameObject.tag == "Luna9")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);

		}

		else if (other.gameObject.tag == "Luna13")
		{
			fundo.SetActive(false);
			objConcluido.SetActive(false);
			informa.text = " ";
			nomeObjeto.text = " ";
			exclama.SetActive(false);
		}

		if (other.gameObject.tag == "Lua") 
		{
			RenderSettings.fog = false;
		}
	}
	void trocaTocando(){
		tocando = false;
		contaFala=0;
	}
}