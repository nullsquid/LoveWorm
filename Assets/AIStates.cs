﻿using UnityEngine;
using System.Collections;

public class AIStates : MonoBehaviour {
	public Character stats;
	public PathAgent agent;
	public Transform target;
	public GameObject home;
	public bool interacting = false;
	public float stateDelay;
	public Canvas talkBubble;
	GameObject instance;
	bool instanceCreated = false;

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
			if(stats.isImplanted != true){
				Calling();
			}
			else if (stats.isImplanted == true){
				//pause game. timescale = 0?
				agent.wander = false;
				other.GetComponent<PathAgent>().wander = false;
				if(instanceCreated == false){
					instance = Instantiate(GetComponent<CharacterTalking>().dialogueMachinePrefab, transform.position, transform.rotation) as GameObject;
					instance.name = this.gameObject.name + " machine";
					instance.transform.position = Vector3.zero;
					instance.transform.rotation = Quaternion.identity;
					Debug.Log(instance);
					instanceCreated = true;
				}
				
			}
		}
		//else if (other.tag == "Player"){
		//	Implanted();
		//}
	}

	void Wandering(){
		agent.wander = true;
		agent.StartCoroutine("WaitAndMove");
	}

	void Calling(){
		interacting = true;
		StartCoroutine("WaitToSpeak");
	}

	void Flirting(){

	}

	void ExitConversation(){
		interacting = false;
		if(talkBubble.enabled == true){
			talkBubble.enabled = false;
		}
		Wandering();
	}

	public void Implanted(){
		Debug.Log("implanted");
		stats.isImplanted = true;

	}

	public void UnImplanted(){
		stats.isImplanted = false;
	}
	

	IEnumerator WaitToSpeak(){
		agent.StopCoroutine("WaitAndMove");
		yield return new WaitForSeconds(2f);
		talkBubble.enabled = true;
		StartCoroutine("NormalConversation");


	}
	IEnumerator NormalConversation(){
		yield return new WaitForSeconds(Random.Range(1, 10));
		ExitConversation();
	}




}
