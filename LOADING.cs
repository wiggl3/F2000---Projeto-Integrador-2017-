using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LOADING : MonoBehaviour {
	
	[Header("NOME DA CENA")]
	[Space(5)]
	public string CenaACarregar;
	public float TempoFixoSeg = 5;
	public enum TipoCarreg {Carregamento, TempoFixo};
	public TipoCarreg TipoDeCarregamento;
	public Image barraDeCarregamento;
	public Text TextoProgresso;
	private int Progresso = 0;
	private string textoOriginal;
	public Text[] curiosidades;
	Text textoEscolhido;
	bool fadein = false;
	float degrade = 0;
	int aux;
	// Use this for initialization
	void Start () 
	{
		int local = Random.Range (0, 16);
		Debug.Log (local);
		aux = local;
		curiosidades [local].enabled = true;
		textoEscolhido = curiosidades [local];
		textoEscolhido.color = new Color (0, 0, 0, 0);
		
		InvokeRepeating ("AumentarCor", 0.1f, 0.1f);
		
		
		switch (TipoDeCarregamento) 
		{
		case TipoCarreg.Carregamento:
			StartCoroutine (CenaDeCarregamento (CenaACarregar));
			break;
		case TipoCarreg.TempoFixo:
			StartCoroutine (TempoFixo (CenaACarregar));
			break;
		}
		//
		if (TextoProgresso != null)
		{
			textoOriginal = TextoProgresso.text;
		}
		if (barraDeCarregamento != null)
		{
			barraDeCarregamento.type = Image.Type.Filled;
			barraDeCarregamento.fillMethod = Image.FillMethod.Horizontal;
			barraDeCarregamento.fillOrigin = (int)Image.OriginHorizontal.Left;
		}
	}
	
	IEnumerator CenaDeCarregamento (string cena)
	{
		AsyncOperation carregamento = SceneManager.LoadSceneAsync (cena);//Quando chamado ele carrega a cena que for escolhida
		while(!carregamento.isDone){
			Progresso = (int)(carregamento.progress * 100.0f);//dira o progresso de carregamento da cena
			yield return null;
		}
	}
	
	IEnumerator TempoFixo(string cena)
	{
		yield return new WaitForSeconds (TempoFixoSeg);
		SceneManager.LoadScene (cena);
	}
	
	void Update () {
		
		switch (TipoDeCarregamento) 
		{
		case TipoCarreg.Carregamento:
			break;
		case TipoCarreg.TempoFixo:
			Progresso = (int)(Mathf.Clamp((Time.time / TempoFixoSeg),0.0f,1.0f)* 100.0f);
			break;
		}
		
		if (TextoProgresso != null)
		{
			TextoProgresso.text = textoOriginal + " " + Progresso + "%";
		}
		if (barraDeCarregamento != null)
		{
			barraDeCarregamento.fillAmount = (Progresso / 100.0f);
		}
		
		//degrade ++;
		
		//textoEscolhido.color = new Color (degrade, 0, 0, 255);
	}
	
	void AumentarCor()
	{
		curiosidades[aux].color = new Color(0.14f,0.89f,0.95f,degrade);
		Debug.Log (degrade);
		if (degrade < 1 && fadein==false) {
			degrade += Time.deltaTime * 1.5f;
		} 
		else {
			fadein=true;
			degrade -= Time.deltaTime * 1.5f;
			if(degrade<=0){
				curiosidades[aux].enabled=false;
				int local = Random.Range (0, 16);
				curiosidades [local].enabled = true;
				curiosidades[local].color = new Color (0.14f,0.89f,0.95f,degrade);
				fadein=false;
				aux=local;
			}
		}
		
		textoEscolhido.color = new Color (0.14f,0.89f,0.95f,degrade);
	}
	
}
