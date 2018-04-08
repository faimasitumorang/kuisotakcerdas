using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assets.SimpleAndroidNotifications
{
public class notifScript : MonoBehaviour {


	public void sendNotif() 
	{

		NotificationManager.SendWithAppIcon(TimeSpan.FromHours(2),
		"Kuis Otak Cerdas",
		"Yakin Anda bisa jawab soal ini",Color.white,
		NotificationIcon.Star);
	}
	}
}
