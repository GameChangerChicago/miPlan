using UnityEngine;
using System.Collections;

public class BackToMyOptions : MonoBehaviour {


	private float myShelf = -15.0f;
	public GameObject sliderTrack;
	public GameObject myOtherBackToOptionsBtn;


	void OnMouseUp(){

				myOtherBackToOptionsBtn.SetActive (true);

				this.transform.parent.transform.position = new Vector2 (0.0f, myShelf);
				SmoothPageSlide_2 pageSlideScript = sliderTrack.GetComponent<SmoothPageSlide_2>();
				pageSlideScript.forceBackBool = true;
				foreach(BoxCollider2D c in sliderTrack.GetComponents<BoxCollider2D> ()) {
						c.enabled = true;
				}
			
				Debug.Log("BacktToMyOption Functions has been triggered. Should be returning to AllMyOptions");
				//this.SetActive (false);


				//This next step may look confusing...It is to reactivate the 3 buttons on the first condoms slide.

				Component[] big3ButtonsOnAnyOptionSlide = this.transform.parent.transform.parent.transform.parent.transform.GetComponentsInChildren<BoxCollider2D> ();
				//print ("this is the blackbtns ArrayList: " + big3ButtonsOnAnyOptionSlide); 
				foreach (BoxCollider2D _1ofBtns in big3ButtonsOnAnyOptionSlide) {
						_1ofBtns.enabled = true;
						Debug.Log (" Re-enabled ... "+_1ofBtns);
				}
	}

}
