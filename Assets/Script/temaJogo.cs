using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class temaJogo : MonoBehaviour {

	public Button 		btnPlay;
	public Text 		txtNomeTema;
	public Text			waktu;

	public GameObject 	infoTema;
	public GameObject popup;
	public Text 		benar;
	public Text 		jumlah;

	public Button 	estrela1;
	public 	Button 	estrela2;
	public Button 	estrela4;


	public string[]	 	nomeTema;
	public string[]	 	nomewaktu;
	public int 			numeroQuestois;

	private int			idTema;
	private int			notaFinal;


	// Use this for initialization
	void Start () {
		idTema = 0;
		txtNomeTema.text = nomeTema[idTema];
		waktu.text = nomeTema[idTema];
		benar.text = ""; 
		jumlah.text = ""; 
		infoTema.SetActive(false);
		estrela1.interactable = false;
		estrela2.interactable = false;
		estrela4.interactable = false;
		btnPlay.interactable = false;
		popup.SetActive(false);
	}
	
	public void selecioneTema(int i)
	{
		idTema = i;
		PlayerPrefs.SetInt ("idTema", idTema);
		txtNomeTema.text = nomeTema[idTema];
		waktu.text = nomewaktu[idTema];

		int notaFinal = PlayerPrefs.GetInt ("notaFinalTemp" + idTema.ToString ());
		int acertos = PlayerPrefs.GetInt ("acertosTemp" + idTema.ToString ());

		benar.text = acertos.ToString();
		jumlah.text = numeroQuestois.ToString();
		infoTema.SetActive(true);
		popup.SetActive(true);
		btnPlay.interactable = true;
		estrela1.interactable = false;
		estrela2.interactable = false;
		estrela4.interactable = false;

		if (notaFinal == 100) {
			estrela1.interactable = true;
			estrela2.interactable = true;
			estrela4.interactable = true;
	
		} else if (notaFinal >= 70) {
			estrela1.interactable = true;
			estrela2.interactable = true;
			estrela4.interactable = false;

		} else if (notaFinal >= 50) {
			estrela1.interactable = true;
			estrela2.interactable = false;
			estrela4.interactable = false;
		}

	}

	public void jogar()
	{
		Application.LoadLevel("T"+idTema.ToString());

	}	
	
}
