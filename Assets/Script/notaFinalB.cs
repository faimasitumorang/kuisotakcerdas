using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class notaFinalB : MonoBehaviour {

	private int idTema;
	public Text txtNota;
	public Text txtInfoTema;
	public GameObject estrela1;
	public GameObject estrela2;
	public GameObject estrela4;
	public Text hebat;
	public Image cahaya;

	private int notaF;
	private int acertos;

	// Use this for initialization
	void Start () {
		idTema = PlayerPrefs.GetInt ("idTemaB");

		estrela1.SetActive (false);
		estrela2.SetActive (false);
		estrela4.SetActive (false);
		cahaya.enabled = false;
		

		notaF = PlayerPrefs.GetInt ("notaFinalTempB" + idTema.ToString ());
		acertos	= PlayerPrefs.GetInt ("acertosTempB" + idTema.ToString ());

		txtNota.text = notaF.ToString ();
		txtInfoTema.text = "Kamu berhasil menjawab " + acertos.ToString () + " dari 10 pertanyaan";

		if (notaF == 100) {
			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela4.SetActive (true);
			hebat.text = "Kamu Jenius!!!";
			cahaya.enabled = true;
	
		} else if (notaF >= 70) {
			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela4.SetActive (false);
			hebat.text = "Kamu hebat!!";
			cahaya.enabled = true;
	
		} else if (notaF >= 50) {
			estrela1.SetActive (true);
			estrela2.SetActive (false);
			estrela4.SetActive (false);
			hebat.text = "Kamu cukup pintar!";
			cahaya.enabled = true;
		}
	}

	public void jogarNovamente()
	{
		Application.LoadLevel("B"+idTema.ToString());
	}
	
}
