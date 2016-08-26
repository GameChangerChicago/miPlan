using UnityEngine;
using System.Collections;

public class PlayMovie_Hormonal : MonoBehaviour {

	int mouseCounter;

	void OnMouseDown(){
		Handheld.PlayFullScreenMovie ("MiPlan_HormonalIUDProRes_iPad.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
		//audio.Play();
		Debug.Log ("Should be playing Hormonal movie now");
	}
}
