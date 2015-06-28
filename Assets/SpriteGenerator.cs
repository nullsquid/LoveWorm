using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SpriteGenerator : MonoBehaviour {

	//public CharacterGenerator charGen;
	public List<Sprite> hair = new List<Sprite>();
	public List<Sprite> faces = new List<Sprite>();
	public List<Sprite> bodies = new List<Sprite>();
	public List<Sprite> legs = new List<Sprite>();
	public List<Sprite> bodyLegs = new List<Sprite>();
	public List<Sprite> feet = new List<Sprite>(); 
	public List<Sprite> topView = new List<Sprite>();

	public Character character;
	Sprite newHair;
	Sprite newFace;
	Sprite newBody;
	Sprite newLegs;
	Sprite newBodyLegs;
	Sprite newFeet;

	void Start(){
		character = gameObject.GetComponent<CharacterGenerator>().characterPrefab;
		Debug.Log(character);
		foreach(SpriteRenderer sprite in character.bodyParts){
			Debug.Log(sprite);
		}


	}

	void MakeSprite(){

	}
}
