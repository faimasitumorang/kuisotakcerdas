 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPanel : MonoBehaviour {

	public GameObject resetPanel;

	// Use this for initialization
	void Start () {
		resetPanel.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
				resetPanel.SetActive (true);
		}
		
	}
}
