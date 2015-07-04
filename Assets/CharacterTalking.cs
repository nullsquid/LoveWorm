using UnityEngine;
using System.Collections;

public class CharacterTalking : MonoBehaviour {
	public GameObject dialogueMachinePrefab;
	GameObject instance;
	public bool instanceCreated = false;
	public Camera camera;

	void Start(){
		camera = Camera.main;
	}
	//to test exiting of conversation mode
	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape)){
			ExitConversationMode();
		}
	}
	public void EnterConversationMode(Collider2D target){
		instance = Instantiate(dialogueMachinePrefab, transform.position, transform.rotation) as GameObject;
		instance.name = this.gameObject.name + " dialogue machine";
		instance.transform.position = Vector3.zero;
		instance.transform.rotation = Quaternion.identity;
		instance.GetComponent<SliderController>().activeChar = this.gameObject;
		instance.GetComponent<SliderController>().passiveChar = target.gameObject;
		instanceCreated = true;
		gameObject.GetComponent<Character>().isEngaging = true;
		camera.GetComponent<CameraFollow>().following = false;

	}

	public void ExitConversationMode(){//Collider2D target){

		instanceCreated = false;
		Destroy(instance);
		gameObject.GetComponent<Character>().isEngaging = false;
		camera.GetComponent<CameraFollow>().following = true;


	}

	IEnumerator ConversationStep(){
		yield return new WaitForSeconds(1);
	}

}
