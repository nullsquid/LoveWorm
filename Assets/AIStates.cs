using UnityEngine;
using System.Collections;

public class AIStates : MonoBehaviour {
	public Character stats;
	public PathAgent agent;
	public Transform target;
	public GameObject home;

	void Start(){
		stats = GetComponent<Character>();
		agent = GetComponent<PathAgent>();
	}

	void Wandering(){
		agent.wander = true;
	}

	void Calling(){

	}


}
