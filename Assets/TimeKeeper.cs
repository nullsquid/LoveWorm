using UnityEngine;
using System.Collections;

public class TimeKeeper : MonoBehaviour {
	
	public float minute;
	public float hour;
	public int day;
	public string dayName;

	public float totalDays;

	void Start(){
		//minute = 0;
		//SetDay (day);
		StartCoroutine("SetDay", day);
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
		StartCoroutine("SetDay", day);
		//Invoke("SetDay");
		if(day>=6){
			day = 0;
		}
		totalDays += 1;
	}

	IEnumerator SetDay(int dayNumber){
		switch(dayNumber){
		case 0:
			dayName = "Sunday";
			break;
		case 1:
			dayName = "Monday";
			break;
		case 2:
			dayName = "Tuesday";
			break;
		case 3:
			dayName = "Wednesday";
			break;
		case 4:
			dayName = "Thursday";
			break;
		case 5:
			dayName = "Friday";
			break;
		case 6:
			dayName = "Saturday";
			break;
		//HACK
		case 7:
			dayName = "Sunday";
			break;
		default:
			dayName = null;
			break;
		}
		Debug.Log("Daynumber = " + dayNumber);
			yield return null;
	}
}
