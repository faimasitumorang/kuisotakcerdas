using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temaInfoA : MonoBehaviour {

	public int idTema;

	public Button estrela1;
	public Button estrela2;
	public Button estrela4;
	public GameObject kunci;

	public Button level;
	private int notaF;

	// Use this for initialization
	void Start () {

		estrela1.interactable = false;
		estrela2.interactable = false;
		estrela4.interactable = false;
		kunci.SetActive(true);
		level.interactable = false;

		int notaF = PlayerPrefs.GetInt ("notaFinalTempA" + idTema.ToString ());

		if (notaF == 100) { 
			estrela1.interactable = true;
			estrela2.interactable = true;
			estrela4.interactable = true;
			kunci.SetActive(false);
			level.interactable = true;
	
		} else if (notaF >= 70) {
			estrela1.interactable = true;
			estrela2.interactable = true;
			estrela4.interactable = false;
			kunci.SetActive(false);
			level.interactable = true;

		} else if (notaF >= 50) {
			estrela1.interactable = true;
			estrela2.interactable = false;
			estrela4.interactable = false;
			kunci.SetActive(false);
			level.interactable = true;

		} else if (notaF >= 10) {
			estrela1.interactable = false;
			estrela2.interactable = false;
			estrela4.interactable = false;
			kunci.SetActive(false);
			level.interactable = true;
		} 
	}
	

	void Update () {

	}

}
