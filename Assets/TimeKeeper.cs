using UnityEngine;
using System.Collections;

public class TimeKeeper : MonoBehaviour {
	
	public float minute;
	public float hour;
	public float day;
	public string dayName;

	public float totalDays;

	void Start(){
		//minute = 0;
	}
	// Update is called once per frame
	void Update () {
		minute += Time.deltaTime;
		if(minute >= 60){
			Invoke("IncrementHour", 0);
			minute = 0;
		}

	}

	void IncrementHour(){
		hour += 1;
		if(hour >= 24){
			hour = 0;
			Invoke("IncrementDay", 0);
		}
	}

	void IncrementDay(){
		day += 1;
		if(day>=6){
			day = 0;
		}
		totalDays += 1;
	}

	/*void SetDay(float dayNumber){
		switch(dayNumber){
		case 0f:
			dayName = "Sunday";
			break;
		case 1f:
			dayName = "Monday";
			break;
		case 2f:
			dayName = "Tuesday";
			break;
		case 3f:
			dayName = "Wednesday";
			break;
		case 4f:
			dayName = "Thursday";
			break;
		case 5f:
			dayName = "Friday";
			break;
		case 6f:
			dayName = "Saturday";
			break;
		default:
			dayName = null;
		}
	}*/
}
