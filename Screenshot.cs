using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.SceneManagement;

public class Screenshot : MonoBehaviour {
	int contador = 0;
	string caminhoPasta;
	Texture2D screenshot;
	int contadorPrint=0,contadorMostra=0;
	public Renderer tela;

	// Use this for initialization
	void Start () {
		PlayerPrefs.DeleteAll();
		PlayerPrefs.GetInt("numeroPrint");
        if (PlayerPrefs.GetInt("numeroPrint") > 0)
        {
            contadorPrint = PlayerPrefs.GetInt("numeroPrint");
        }
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log(contadorMostra);
		/*if(Input.GetKeyDown(KeyCode.P)){
			contador++;
			Application.CaptureScreenshot("Screenshot " + contador.ToString() + ".png");

		}*/


		//ate aqui funciona, mas vou modificar para fins de teste
		/*if (Input.GetKeyDown(KeyCode.P)){
			Debug.Log ("Selfie-maker");

			folderPath = Application.persistentDataPath + "/screenshot.png"; 
			Application.CaptureScreenshot(folderPath);

			Debug.Log ("Screenshot number " + screenshotCount +" taken!");
			screenshotCount++; 

		}
		if(Input.GetKeyDown(KeyCode.N)){

			Debug.Log ("Anders");
			string fileName = Path.Combine(Application.persistentDataPath, "screenshot.png");
			byte[] bytes = System.IO.File.ReadAllBytes(fileName);
			screenshot = new Texture2D(0,0,TextureFormat.ASTC_RGB_12x12, false);
			screenshot.LoadImage(bytes);
			tela.material.mainTexture = screenshot;
		}*/
		if (Input.GetKeyDown(KeyCode.Alpha3)){

			caminhoPasta = Application.persistentDataPath + "/screenshot" + contadorPrint.ToString()+".png"; 
			Application.CaptureScreenshot(caminhoPasta);
			contadorPrint++; 
			if(contadorPrint>PlayerPrefs.GetInt("numeroPrint"))
				PlayerPrefs.SetInt("numeroPrint",contadorPrint);
		}
		if(Input.GetKeyDown(KeyCode.Alpha4) /*&& SceneManager.GetActiveScene().name=="MuseuTutorial"*/){
			string arquivoNome = Path.Combine(Application.persistentDataPath, "screenshot" + contadorMostra.ToString()+".png");
			byte[] bytes = System.IO.File.ReadAllBytes(arquivoNome);
			screenshot = new Texture2D(0,0,TextureFormat.ASTC_RGB_12x12, false);
			screenshot.LoadImage(bytes);
			tela.material.mainTexture = screenshot;
			contadorMostra++;
			if(contadorMostra>=PlayerPrefs.GetInt("numeroPrint")){
				contadorMostra=0;
			}
		} 
	}

}
