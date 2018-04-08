using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temaInfo2B : MonoBehaviour {

	public int idTema;

	public Button estrela1;
	public Button estrela2;
	public Button estrela4;
	private int notaF;

	// Use this for initialization
	void Start () {

		estrela1.interactable = false;
		estrela2.interactable = false;
		estrela4.interactable = false;

		int notaF = PlayerPrefs.GetInt ("notaFinalTempB" + idTema.ToString ());

		if (notaF == 100) { 
			estrela1.interactable = true;
			estrela2.interactable = true;
			estrela4.interactable = true;
		
			
	
		} else if (notaF >= 70) {
			estrela1.interactable = true;
			estrela2.interactable = true;
			estrela4.interactable = false;
		
			

		} else if (notaF >= 50) {
			estrela1.interactable = true;
			estrela2.interactable = false;
			estrela4.interactable = false;
		
			

		} else if (notaF >= 10) {
			estrela1.interactable = false;
			estrela2.interactable = false;
			estrela4.interactable = false;
		
			
		} 
	}
	

	void Update () {

	}

}
