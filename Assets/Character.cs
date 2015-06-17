using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {

	public bool hasTits;

	public string gender;
	public string characterName;

	//what they're attracted to
	public List<string> likes = new List<string>();


	//other characteristics, e.g. likes/dislikes
	public List<string> traits = new List<string>();

	//public 

	public List<SpriteRenderer> bodyParts = new List<SpriteRenderer>();


}
