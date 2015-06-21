using UnityEngine;
using System.Collections;

public class AIStates : MonoBehaviour {
	public Character stats;
	public PathAgent agent;
	public Transform target;
	public GameObject home;
	public bool interacting = false;
	public float stateDelay;

	void Start(){
		stats = GetComponent<Character>();
		agent = GetComponent<PathAgent>();
	}

	void Update(){
		if(interacting == true){
			agent.wander = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Host"){
			Calling();
		}
	}

	void Wandering(){
		agent.wander = true;
	}

	void Calling(){
		interacting = true;
	}

	void Flirting(){

	}

	void ExitConversation(){

	}




}
