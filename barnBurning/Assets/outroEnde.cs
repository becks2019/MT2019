using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class outroEnde : MonoBehaviour
{
    //Dieses Skript beendet die Applikation, wenn das Outro abgelaufen ist
	public VideoPlayer VideoPlayer;

	// Start is called before the first frame update
	void Start()
    {
        //Beim Ende des Videos wird die Funktion EndApplication aufgerufen
		VideoPlayer.loopPointReached += EndApplication;

	}

    // die Applikation wird beendet
    void EndApplication(VideoPlayer vp)
    {
		Application.Quit();
	}
}
