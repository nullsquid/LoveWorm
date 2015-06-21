using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using PigeonCoopToolkit;


public class PathAgent : MonoBehaviour {

	public Transform target;
	public GameObject targetMarker;
	public List<Vector2> path;



	//bool goToTarget = false;
	public bool wander;

	void Start(){
		StartCoroutine("WaitAndMove");
    }
	void Update(){
		Debug.Log(wander);

        MoveToTarget();



	}

	void MoveToTarget(){


		//Debug.Log(path);
		//Debug.Log(path.Count);
		if(path != null && path.Count != 0)
		{
			//transform.LookAt(target);
			transform.position = Vector2.MoveTowards(transform.position, path[0], 1*Time.deltaTime);
			if(Vector2.Distance(transform.position,path[0]) < 0.01f)
			{
				path.RemoveAt(0);
				//goToTarget = false;
			}
			
			if(Vector2.Distance(transform.position, target.transform.position) < 0.5f){
				//Destroy(target.transform.parent);
				//goToTarget = false;

				NewTarget();

			}
		}
	}

	void SetTarget(){
		path = NavMesh2D.GetSmoothedPath(transform.position, target.transform.position);
	}
	void NewTarget(){

		//targetMarker.transform.position = 
	}


	IEnumerator WaitAndMove(){
		//float timer;
		while(wander == true){
			yield return new WaitForSeconds(3);
			SetTarget();
		}
		
	}
}



