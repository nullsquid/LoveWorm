using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class SliderController : MonoBehaviour {
	
	
	public float characterDesireStrength;
	public float characterDesireRate;
	public float loveWormInfluenceTick;
	
	public float timeUntilFail;
	
	public bool isActive;
	
	public GameObject activeChar;
	public GameObject passiveChar;
	


	public List<string> responseTones = new List<string>();
	
	public Slider slider;
	public Slider timeCounter;
	
	void Awake(){
		timeCounter.maxValue = timeUntilFail;
		timeCounter.value = timeCounter.maxValue;
	}
	
	void Start(){
		StartCoroutine("Slide", characterDesireRate);
	}
	
	void SlideUp(float amount){
		slider.value += amount;
	}
	void SlideDown(float amount){
		slider.value -= amount;
	}
	
	void Fail(){
		Debug.Log("Fail");
		GetComponentInChildren<Canvas>().enabled = false;
		
	}
	
	IEnumerator Slide(float tickLength){
		while(slider.value != slider.maxValue || slider.value != slider.minValue){
			yield return new WaitForSeconds(tickLength);
			SlideUp(characterDesireStrength);
		}
	}
	void Update(){
		timeUntilFail -= Time.deltaTime;
		//timeCounter.value = timeUntilFail;
		if(timeUntilFail <= 0){
			//if(
			//might want to make it a threshold thing
			//If players are within range of the option they want then they get it when time runs out
			Fail ();
		}
		
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			SlideDown(loveWormInfluenceTick);
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow)){
			SlideUp(loveWormInfluenceTick);
		}
		
		if(slider.value >= slider.maxValue){
			Debug.Log("option A");
			StopCoroutine("Slide");
			//slider.enabled = false;
			//gameObject.enabled
			//slider.
			Fail ();
			
		}
		else if (slider.value <= slider.minValue){
			Debug.Log("option B");
			StopCoroutine("Slide");
			//slider.enabled = false;
			Fail ();
		}
	}
	void LateUpdate(){
		timeCounter.value = timeUntilFail;
	}
}
