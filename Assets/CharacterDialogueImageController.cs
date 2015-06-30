using UnityEngine;
using System.Collections;

public class CharacterDialogueImageController : MonoBehaviour {


	public GameObject activePortrait;
	public GameObject passivePortrait;

	//variables for positioning

	void Awake(){
		//activePortrait.transform.localPosition.y = Screen.height/2;
	}

	// Use this for initialization
	void Start () {
		//activePortrait.transform.localPosition = new Vector3(Screen.width/2, Screen.height/2, transform.localPosition.z);
		//activePortrait.transform.position = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width/2, Screen.height/2, transform.localPosition.z));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
