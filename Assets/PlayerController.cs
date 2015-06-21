using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public bool canControl;
	public float moveSpeed;
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

		if(gameObject.GetComponent<PlayerStats>().hasHost == true){
			//add host to list, follow host around
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Host"){
			canControl = false;
			gameObject.GetComponent<PlayerStats>().hasHost = true;
			transform.position = other.transform.position;
		}
	}

	void Hosted(){
		//transform.position = 
	}
}
