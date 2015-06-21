using UnityEngine;
using System.Collections;

public class ExitWall : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Vector2 newPos = Random.insideUnitCircle * 2;
		transform.position = newPos;
	}
}
