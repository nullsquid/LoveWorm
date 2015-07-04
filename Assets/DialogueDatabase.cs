using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DialogueDatabase : MonoBehaviour {

	public Dictionary<string, string> flirty = new Dictionary<string, string>();
	// Use this for initialization
	void Start () {
		flirty.Add("flirty", "fuck you faggot~");
	}

}
