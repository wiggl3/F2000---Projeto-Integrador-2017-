using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CIENTISTAS : MonoBehaviour {
	
	[SerializeField]
	GameObject painel; //painel onde aparece imagens e textos
	
	[SerializeField] //Imagem onde ficara o sprite
	Image cientistas;
	
	[SerializeField]
	Sprite[] fotoCientista; //array com as fotos
	
	[SerializeField]
	Text descricao, nomes;
	
	[SerializeField]
	Button sair;
	
	// Use this for initialization
	void Start () {
		painel.SetActive (false); //painel comeca falso e texto em branco
		descricao.text = descricao.ToString ();
		descricao.text = " ";
		
		descricao.text = nomes.ToString ();
		nomes.text = " ";
		
		sair.onClick = new Button.ButtonClickedEvent();
		sair.onClick.AddListener(() => Sair());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown()
	{
		if (gameObject.tag.Equals ("Copernico")) //se a tag do personagem for essa
		{
			painel.SetActive(true); //painel é verdadeiro
			cientistas.GetComponent<Image>().sprite = fotoCientista[0]; //pega o sprite do cientista escolhido
			//texto do cientista
			descricao.text = "Importante matemático e astronômono polonês. Considerado o “pai” da astronomia, pois, através de seus estudos e cálculos propôs que a Terra, assim como os demais planetas giravam em torno do Sol, o Heliocentrismo. Além disso, também deduziu que a Terra girava em torno do seu próprio eixo. Por “retirar” o homem do centro do universo (antropocentrismo), foi considerado um herege pela Igreja.";
			nomes.text = "Nicolau Copérnico (1473-1543)";
		}
		
		if (gameObject.tag.Equals ("Einstein")) 
		{
			painel.SetActive(true);
			cientistas.GetComponent<Image>().sprite = fotoCientista[1];
			descricao.text = "Físico teórico alemão e o mais célebre cientista de todo o século XX, responsável por propor e desenvolver a teoria da relatividade geral. Einstein sugeriu que as leis da física são as mesmas em todo o universo, que a velocidade da luz no vácuo é constante, e que o espaço e o tempo estão ligados em uma entidade conhecida como espaço-tempo, que é distorcida pela gravidade. ";
			nomes.text = "Albert Einstein (1879-1955)";
		}
		
		if (gameObject.tag.Equals ("Galileu")) 
		{
			painel.SetActive(true);
			cientistas.GetComponent<Image>().sprite = fotoCientista[2];
			descricao.text = "Físico e Astrônomo italiano, comumente reconhecido como o criador do telescópio óptico, embora ele tenha apenas aperfeiçoado modelos já existentes. Galileu utilizou esse o telescópio que ele mesmo construiu para observar o céu e, dessa forma, descobriu as quatro principais luas de Júpiter (conhecidas, atualmente, como luas de Galileu), são elas: Io, Europa, Ganímedes e Calisto. Também foi responsável por descobrir os anéis de Saturno. Além disso, foi um grande defensor da teoria do Heliocentrismo (cuja Terra gira em torno do Sol, e não o contrário) e passou os anos finais de sua vida em prisão domiciliar por isso. ";
			nomes.text = "Galileu Galilei (1564-1642)";
		}
		
		if (gameObject.tag.Equals ("Hubble")) 
		{
			painel.SetActive(true);
			cientistas.GetComponent<Image>().sprite = fotoCientista[3];
			descricao.text = "Astrônomo Americano, famoso por ter descoberto que as nebulosas (ou como eram chamadas, até então) eram, na realidade, galáxias fora da Via Láctea e que afastavam-se umas das outras à uma velocidade proporcional a distância que as separa. Também determinou que o universo estava se expandindo, cálculo esse que ficou conhecido como Lei de Hubble. Suas observações de várias galáxias levaram a um padrão de classificação que é utilizado até hoje. Em sua homenagem, um dos mais famosos telescópios do mundo leva seu nome: O telescópio Hubble, responsável captar informações e imagens de lugares distantes no universo.";
			nomes.text = "Edwin Hubble (1899-1953) ";
		}
		
		if (gameObject.tag.Equals ("Huygens")) 
		{
			painel.SetActive(true);
			cientistas.GetComponent<Image>().sprite = fotoCientista[4];
			descricao.text = "Físico e astrônomo holandês. Propôs a primeira teoria sobre a natureza da luz, além de fazer melhorias no telescópio que permitiram-no observar os anéis de Saturno e descobrir sua lua: Titã. Também criou a teoria sobre o estudo da luz e cores, descobrindo que por meio da luz é possível a ocorrência de fenômenos de propagação, como a reflexão e a refração.";
			nomes.text = "Christiaan Huygens (1629-1695)";
		}
		
		if (gameObject.tag.Equals ("Kepler")) 
		{
			painel.SetActive(true);
			cientistas.GetComponent<Image>().sprite = fotoCientista[5];
			descricao.text = "Astrônomo e matemático alemão e uma das figuras-chave da revolução científica no século XVII. Utilizando de medições detalhadas da trajetória dos planetas, feitas pelo astrônomo dinamarquês Tycho Brahe, Kepler propôs que os planetas orbitavam o sol em formato de elipse, não círculos. Para sustentar sua tese, calculou três leis referentes aos movimentos dos planetas, as leis de Kepler \n \n 1a Lei: Os planetas descrevem órbitas elipticas em torno do Sol, que ocupa um dos focos da elipse. \n \n 2a Lei: A linha reta que une o Sol ao planeta varre áreas iguais em intervalos de tempo iguais. \n \n 3a Lei: Os quadrados dos períodos orbitais dos planetas são proporcionais aos cubos dos semi-eixos maiores das órbitas (P2=ka3).";
			nomes.text = "Johannes Kepler (1571-1630)";
		}
		
		if (gameObject.tag.Equals ("Newton")) 
		{
			painel.SetActive(true);
			cientistas.GetComponent<Image>().sprite = fotoCientista[6];
			descricao.text = "Astrônomo, físico e matemático inglês, é um dos mais importantes nomes da história da ciência. Dentre diversas invenções, é bastante reconhecido por seu trabalho sobre forças, mais especificamente a gravidade. Calculou três leis que descrevem o movimento das forças entre objetos, as leis de Newton. \n \n1ª Lei – Princípio da Inércia: ''Todo corpo permanece em seu estado de repouso, ou de movimento uniforme em linha reta, a menos que seja obrigado a mudar seu estado por forças impressas nele. \n \n 2ª Lei – A força: ''A mudança do movimento é proporcional à força matriz impressa e se faz segundo a linha reta pela qual se imprime essa força. \n \n 3ª Lei – Princípio da Ação e Reação: ''A uma ação sempre se opõe uma reação igual, ou seja, as ações de dois corpos um sobre o outro são sempre iguais e se dirigem a partes contrárias.''";
			nomes.text = "Isaac Newton (1643-1727) ";
		}
		
		if (gameObject.tag.Equals ("Ptolomeu")) 
		{
			painel.SetActive(true);
			cientistas.GetComponent<Image>().sprite = fotoCientista[7];
			descricao.text = "Um matemático e astrônomo da Grécia antiga, responsável por criar o “sistema de Ptolomeu” que consistia em um modelo de sistema solar em que o sol, as estrelas e os demais planetas todos giravam em torno da Terra. Tal modelo, apesar de ser provado como errado posteriormente foi reconhecido como correto por centenas de anos. Além disso, Ptolomeu é considerado o primeiro “cientista celeste”, possuindo colaborações nas áreas da matemática, astrologia, astronomia, geografia, cartografia, óptica e, até mesmo, teoria musical.";
			nomes.text = "Cláudio Ptolomeu (90 d.C. - 168 d.C.)";
		}
		
		if (gameObject.tag.Equals ("Sagan")) 
		{
			painel.SetActive(true);
			cientistas.GetComponent<Image>().sprite = fotoCientista[8];
			descricao.text = "Astrônomo Americano, teve um papel importante no início do desenvolvimento de programas espaciais pela recém criada NASA, além de ter colaborado para o desenvolvimento da Apollo 11. Também possuí colaboração expressiva no lançamento das sondas Galileu e Voyager, além de mostrar que Titã – uma das luas de Saturno – possuía oceanos de compostos líquidos. Entretanto, era como um divulgador científico que Sagan se destacava, sendo o astrônomo que mais popularizou a astronomia em toda a história, atraindo diversos telespectadores e aproximando o público leigo da ciência, inspirando toda uma geração de cientistas e astrônomos. ";
			nomes.text = "Carl Sagan (1934 – 1996)";
		}
		
		if (gameObject.tag.Equals ("Hawking")) 
		{
			painel.SetActive(true);
			cientistas.GetComponent<Image>().sprite = fotoCientista[9];
			descricao.text = "Físico teórico e cosmólogo britânico, responsável por contribuições fundamentais ao estudo dos buracos negros. Propôs também que, como o universo tem um começo, provavelmente também terá um fim, além de acreditar que o mundo não possui nenhum limite ou fronteira. É visto como o físico teórico mais brilhante desde Einstein, mas apesar disso, possuí muitos livros adaptados, voltados para o público em geral, uma vez que Hawking procura educar as pessoas acerca do universo. ";
			nomes.text = "Stephen Hawking (1942 - XXXX)";
		}
	}
	
	void Sair()
	{
		painel.SetActive (false);
	}
}
