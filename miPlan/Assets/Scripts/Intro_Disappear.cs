using UnityEngine;
using System.Collections;

public class Intro_Disappear : MonoBehaviour {


	private GameObject myParent;

	// Use this for initialization
	void Start () {
		myParent = this.transform.parent.gameObject;
	}
	

	void OnMouseDown(){
		myParent.SetActive (false);
	}
}
