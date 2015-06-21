using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	public float jumpRange;
	public float stamina;
	public float health = 100f;
	public float healthTick = 3.0f;
	public float healthDegradeValueWithoutHost = 10f;
	public float timer = 0;
	public float speed;

	public bool hasHost;

	public Character host;

	void Update(){
		timer += Time.deltaTime;
		if(hasHost == false){
			if(timer >= healthTick){
				HealthDrain(healthDegradeValueWithoutHost);
			
			}
			if(health <= 0){
				Death();
			}
		}
		else if(hasHost == true){
			return;
		}
	}

	void HealthDrain(float drainRate){

		health -= drainRate;
		timer = 0;

	}

	void StaminaUse(float amountUsedUp){

	}

	void Fatigued(){

	}

	void Death(){

	}


}
