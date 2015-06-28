using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public bool canControl;
	public float moveSpeed;
	//public PlayerStats stats;
	public GameObject host;
	// Use this for initialization
	void Start () {
		moveSpeed = gameObject.GetComponent<PlayerStats>().speed; 
		canControl = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(canControl == true){
			if(Input.GetAxis("Vertical") > 0){
				transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
			}
			else if (Input.GetAxis("Vertical") < 0){
				transform.Translate(-Vector2.up * Time.deltaTime * moveSpeed);
			}

			if(Input.GetAxis("Horizontal") > 0){
				transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
			}

			else if (Input.GetAxis("Horizontal") < 0){
				transform.Translate(-Vector2.right * Time.deltaTime * moveSpeed);
			}
		}
		//stand in, should make an "attached" boolean
		if(gameObject.GetComponent<PlayerStats>().hasHost == true){

		}
		if(gameObject.GetComponent<PlayerStats>().hasHost == true){
			//add host to list, follow host around
		}
	}

	void OnTriggerEnter2D(Collider2D other){

	}
	void OnTriggerStay2D(Collider2D other){
		if(gameObject.GetComponent<PlayerStats>().hasHost == false){
			if(other.tag == "Host"){
				Hosted(other);
			}
		}
		else if (gameObject.GetComponent<PlayerStats>().hasHost == true){
			if(Input.GetKey(KeyCode.LeftControl)){
				UnHosted(other);
			}
		}
	}

	void Hosted(Collider2D other){
		canControl = false;

		gameObject.GetComponent<PlayerStats>().hasHost = true;
		host = other.gameObject;
		//transform.position = other.transform.position;
		//other.transform
		gameObject.transform.SetParent(other.transform);
		other.GetComponent<AIStates>().Invoke("Implanted", 0);
		//transform.position = 
	}

	void UnHosted(Collider2D other){
		StartCoroutine("DetachFromHost");
		other.GetComponent<AIStates>().Invoke("UnImplanted", 0);
		Debug.Log("unimplant");

	}
	IEnumerator DetachFromHost(){
		gameObject.transform.parent.DetachChildren();
		canControl = true;
		yield return new WaitForSeconds(1.0f);
		//host = null;
		gameObject.GetComponent<PlayerStats>().hasHost = false;
		if(host != null){
			host = null;
		}
	}
}
