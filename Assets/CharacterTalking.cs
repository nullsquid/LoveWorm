using UnityEngine;
using System.Collections;

public class CharacterTalking : MonoBehaviour {
	public GameObject dialogueMachinePrefab;
	GameObject instance;
	public bool instanceCreated = false;

	public void EnterConversationMode(Collider2D target){
		instance = Instantiate(dialogueMachinePrefab, transform.position, transform.rotation) as GameObject;
		instance.name = this.gameObject.name + " machine";
		instance.transform.position = Vector3.zero;
		instance.transform.rotation = Quaternion.identity;
		instanceCreated = true;
		gameObject.GetComponent<Character>().isEngaging = true;
	}

	public void ExitConversationMode(Collider2D target){
		instanceCreated = false;
		Destroy(instance);
		gameObject.GetComponent<Character>().isEngaging = false;

	}

}
