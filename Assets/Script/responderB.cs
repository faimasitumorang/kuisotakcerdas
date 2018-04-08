using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class responderB : MonoBehaviour {

	private int idTema;

	public Text pergunta;
	public Text respostaA;
	public Text respostaB;
	public Text respostaC;
	public Text respostaD;
	public Text infoResposta;

	public string[] perguntas;
	public string[] alternativeA;
	public string[] alternativeB;
	public string[] alternativeC;
	public string[] alternativeD;
	public string[] corretas;

	private int idPergunta;

	private float acertos;
	private float questoes;
	private float media;
	private int notaFinal;

	private int temaJogo;
	public int timeLeft = 5;
	public Text countdownText;

	// Use this for initialization
	void Start () {
		StartCoroutine("LoseTime");
		idTema = PlayerPrefs.GetInt ("idTemaB");
		idPergunta = 0;
		questoes = perguntas.Length;

		pergunta.text = perguntas[idPergunta];
		respostaA.text = alternativeA[idPergunta];
		respostaB.text = alternativeB[idPergunta];
		respostaC.text = alternativeC[idPergunta];
		respostaD.text = alternativeD[idPergunta];

		infoResposta.text = ""+(idPergunta + 1);

		
	}
	
	// Update is called once per frame
	public void resposta(string alternative) {
		if (alternative == "A") {
			if (alternativeA [idPergunta] == corretas [idPergunta]) {
				acertos += 1;
			}
		} else if (alternative == "B") {
			if (alternativeB [idPergunta] == corretas [idPergunta]) {
				acertos += 1;
			}
		} else if (alternative == "C") {
			if (alternativeC [idPergunta] == corretas [idPergunta]) {
				acertos += 1;
			}
		} else if (alternative == "D") {
			if (alternativeD [idPergunta] == corretas [idPergunta]) {
				acertos += 1;
			}
		}

		proximaPergunta ();
	}
		

		void proximaPergunta()
		{
			idPergunta += 1;

		if(idPergunta <= (questoes-1))
		{

			pergunta.text = perguntas[idPergunta];
			respostaA.text = alternativeA[idPergunta];
			respostaB.text = alternativeB[idPergunta];
			respostaC.text = alternativeC[idPergunta];
			respostaD.text = alternativeD[idPergunta];

			infoResposta.text = ""+(idPergunta + 1);

		}
		else
		{

			media = 100 * (acertos / questoes);
			notaFinal = Mathf.RoundToInt (media);

			if(notaFinal > PlayerPrefs.GetInt("notaFinalB"+idTema.ToString()))
				{
				PlayerPrefs.SetInt ("notaFinalB" + idTema.ToString (), notaFinal);
				PlayerPrefs.SetInt ("acertosB" + idTema.ToString (), (int) acertos);
				}


			PlayerPrefs.SetInt ("notaFinalTempB" + idTema.ToString (), notaFinal);
			PlayerPrefs.SetInt ("acertosTempB" + idTema.ToString (), (int) acertos);

			Application.LoadLevel ("notaFinalB");

	}
	}
	void Update()
	{
		countdownText.text = ("" + timeLeft);

		if (timeLeft <= 0)
		{
			StopCoroutine("LoseTime");
			

			media = 100 * (acertos / questoes);
			notaFinal = Mathf.RoundToInt (media);

			if(notaFinal > PlayerPrefs.GetInt("notaFinalB"+idTema.ToString()))
			{
				PlayerPrefs.SetInt ("notaFinalB" + idTema.ToString (), notaFinal);
				PlayerPrefs.SetInt ("acertosB" + idTema.ToString (), (int) acertos);
			}

			PlayerPrefs.SetInt ("notaFinalTempB" + idTema.ToString (), notaFinal);
			PlayerPrefs.SetInt ("acertosTempB" + idTema.ToString (), (int) acertos);

			Application.LoadLevel ("notaFinalB");


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