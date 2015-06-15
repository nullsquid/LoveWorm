using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterGenerator : MonoBehaviour {

	public List<Character> characters = new List<Character>();
	public int numberOfCharacters = 5;
	public Character characterPrefab;
	public CharacteristicDatabase database;
	public SpriteGenerator spriteGen;

	// Use this for initialization
	void Awake () {
		Character newCharacter;
		for(int i = 0; i <= numberOfCharacters; i++){
			int newNameIndex;
			bool named = false;
			newCharacter = Instantiate(characterPrefab, transform.position, transform.rotation) as Character;
			newCharacter.gender = database.allGenders[Random.Range(0, database.allGenders.Count)];
			if(newCharacter.gender == "Male"){
			
				newNameIndex = Random.Range(0, database.allMaleNames.Count);
				newCharacter.characterName = database.allMaleNames[newNameIndex];
				database.allMaleNames.Remove(database.allMaleNames[newNameIndex]);

				//newCharacter.characterName = database.allMaleNames[Random.Range(0, database.allMaleNames.Count)];
			}
			else if(newCharacter.gender == "Female"){
				newNameIndex = Random.Range(0, database.allFemaleNames.Count);
				newCharacter.characterName = database.allFemaleNames[newNameIndex];
				database.allFemaleNames.Remove(database.allFemaleNames[newNameIndex]);			
			}
			else{
				newNameIndex = Random.Range(0, database.allGenderweirdNames.Count);
				newCharacter.characterName = database.allGenderweirdNames[newNameIndex];
				database.allGenderweirdNames.Remove(database.allGenderweirdNames[newNameIndex]);				
			}
			if(Random.Range(0,1)==0){
				newCharacter.hasTits = true;
			}
			else{
				newCharacter.hasTits = false;
			}
		}
	}

}
