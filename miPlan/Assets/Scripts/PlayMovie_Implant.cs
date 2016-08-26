using UnityEngine;
using System.Collections;

public class PlayMovie_Implant : MonoBehaviour {

		int mouseCounter;

		void OnMouseDown(){
		Handheld.PlayFullScreenMovie ("MiPlan_ImplantProRes_iPad.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
				Debug.Log ("Should be playing implant movie now");
				//audio.Play();
		}

	void Update()
	{
		//Debug.Log (this.GetComponent<AudioSource> ().isPlaying);
	}
}
