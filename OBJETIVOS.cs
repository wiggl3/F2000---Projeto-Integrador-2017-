using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OBJETIVOS : MonoBehaviour {
	RectTransform metas;
	public bool isOpen;
    [SerializeField]
	Button dropdown;
	[SerializeField]
	Toggle [] obj;
	// Use this for initialization
	void Start () {
		metas = transform.FindChild ("Objetivos").GetComponent<RectTransform> ();
		isOpen = false;

		/*dropdown.onClick = new Button.ButtonClickedEvent ();
		dropdown.onClick.AddListener (() => Open ());*/
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 scale = metas.localScale;
		scale.y = Mathf.Lerp (scale.y,isOpen ? 1 : 0, Time.deltaTime * 12);
		metas.localScale = scale;

		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			isOpen = !isOpen;
		}
	}

	/*void Open()
	{
		isOpen = !isOpen;
	}*/


}
