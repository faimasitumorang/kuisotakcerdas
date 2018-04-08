using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour


{
	public int timeLeft = 5;
	public Text countdownText;
	private int idTema;
	private float acertos;
	private int notaFinal;

	// Use this for initialization
	void Start()
	{
		StartCoroutine("LoseTime");
	}

	// Update is called once per frame
	void Update()
	{
		countdownText.text = ("Time Left = " + timeLeft);

		if (timeLeft <= 0)
		{
			StopCoroutine("LoseTime");
			countdownText.text = "Times Up!";
			if(notaFinal > PlayerPrefs.GetInt("notaFinal"+idTema.ToString()))
			{
				PlayerPrefs.SetInt ("notaFinal" + idTema.ToString (), notaFinal);
				PlayerPrefs.SetInt ("acertos" + idTema.ToString (), (int) acertos);
			}

			PlayerPrefs.SetInt ("notaFinalTemp" + idTema.ToString (), notaFinal);
			PlayerPrefs.SetInt ("acertosTemp" + idTema.ToString (), (int) acertos);

			Application.LoadLevel ("notaFinal");


		}
	}

	IEnumerator LoseTime()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			timeLeft--;
		}
	}
}