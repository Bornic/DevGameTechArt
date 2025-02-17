using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeChange : MonoBehaviour
{

    [SerializeField] GameObject MinuteUp;
    [SerializeField] GameObject MinuteDown;
    [SerializeField] GameObject HourUp;
    [SerializeField] GameObject HourDown;
    [SerializeField] TextMeshPro Minute;
    [SerializeField] TextMeshPro Hour;
    [SerializeField] TextMeshPro Uptime;
    private string uptime;
	private int minutes = 0;
    private int hours = 12;

    private void Start()
    {
       

        UpdateClockDisplayMinutes();
		UpdateClockDisplayHours();
	}

    private void OnMouseDown()
    {
        if (gameObject == MinuteUp) // Если кликнули по
        {
            ChangeMinutes(1);
            
        }
        else if (gameObject == MinuteDown)
        {
            ChangeMinutes(-1);
            
        }
        else if (gameObject == HourUp)
        {
            ChangeHours(1);
            
        }
        else if (gameObject == HourDown)
        {
            ChangeHours(-1);
            
        }
    }

    private void ChangeMinutes(int amount)
    {
        minutes = int.Parse(Minute.text);
        minutes += amount;
        if (minutes >= 60)
        {
            minutes = 0;
            
        }
        else if (minutes < 0)
        {
            minutes = 59;
            
        }
        UpdateClockDisplayMinutes();
    }

    private void ChangeHours(int amount)
    {
        hours = int.Parse(Hour.text);
        hours += amount;
        if (hours > 12) hours = 1;
        if (hours < 1) hours = 12;
        UpdateClockDisplayHours();
    }

    private void UpdateClockDisplayMinutes()
    {
        Minute.text = minutes.ToString("D2"); // Двузначный формат
		Uptime.text = "Время подъема " + Hour.text + ":" + Minute.text;

	}
    private void UpdateClockDisplayHours()
    {
		Hour.text = hours.ToString();
		Uptime.text = "Время подъема " + Hour.text + ":" + Minute.text;
	}


// Update is called once per frame
	void Update()
    {
        
    }
}
