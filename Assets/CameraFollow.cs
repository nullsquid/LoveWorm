using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	//public Transform target;
	public float dampingTime =0.15f;
	Vector3 velocity = Vector3.zero;

	/*
	public Camera camera;
	void Start(){
		camera = Camera.main;
	}
	// Update is called once per frame
	void Update () 
	{
		/*if (target)
		{
			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampingTime);
		}
		
	}*/
	public bool following;
	public float interpVelocity;
	public float minDistance;
	public float followDistance;
	public GameObject target;
	public Vector3 offset;
	Vector3 targetPos;
	// Use this for initialization
	void Start () {
		targetPos = transform.position;
		following = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(following){
			if (target)
			{
				Vector3 posNoZ = transform.position;
				posNoZ.z = target.transform.position.z;
			
				Vector3 targetDirection = (target.transform.position - posNoZ);
			
				interpVelocity = targetDirection.magnitude * 5f;
			
				targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime); 
			
				transform.position = Vector3.Lerp( transform.position, targetPos + offset, 0.25f);
			
			}
		}
		else if(!following){
			ConversationCamera();
		}
	}

	public void ConversationCamera(){
		GetComponent<Camera>().transform.localPosition = new Vector3(0, 0, 0);
	}
}
