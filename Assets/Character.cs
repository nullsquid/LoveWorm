using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {

	public bool hasTits;

	public bool isEngaging;
	public bool isEngagedWith;
	public bool isImplanted = false;
	//written characteristics
	public string gender;
	public string characterName;

	public Sprite spriteTop;
	public Sprite spriteSide;
	//stats
	public float fatigue;
	public float arousal;
	public float safety;
	public float euphoria;

	//public List<string> DialogueFlirty

	//what they're attracted to
	public List<string> likes = new List<string>();


	//other characteristics, e.g. likes/dislikes
	public List<string> traits = new List<string>();

	public List<Character> friends = new List<Character>();
	public List<Character> enemies = new List<Character>();
	public List<Character> crushes = new List<Character>();
	public List<Character> romanticHistory = new List<Character>();


	public List<SpriteRenderer> bodyParts = new List<SpriteRenderer>();

	//===STATES===//
	//idle
	//


}
