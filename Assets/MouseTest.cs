using UnityEngine;
using System.Collections;

public class MouseTest : MonoBehaviour {

	public GameObject target;

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			target.transform.position = Input.mousePosition;
		}
	}
}
