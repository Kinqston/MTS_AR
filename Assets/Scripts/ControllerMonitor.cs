using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMonitor : MonoBehaviour {
    public GameObject buttonPlay;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject batton1;
    public GameObject batton2;
    public GameObject batton3;
    public GameObject batton4;
    public GameObject batton5;
    public GameObject chek;

    public GameObject Chat2;
    public GameObject NPC;

    public GameObject[] ball;

    public GameObject chest;

    // Use this for initialization
    void Start () {
      //  Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
	
	// Update is called once per frame
	void Update () {
	  
                
	}

    public void VisibleMonitorStart()
    {
        image1.SetActive(true);
        batton1.SetActive(true);
    }

        public void VisibleMonitor() {
       // Debug.Log("ez");
        image1.SetActive(false);
        image2.SetActive(true);

        batton1.SetActive(false);
        batton2.SetActive(true);
    }
    public void VisibleMonitor2()
    {
        image2.SetActive(false);
        image3.SetActive(true);

        batton2.SetActive(false);
        batton3.SetActive(true);
    }
    public void VisibleMonitor3()
    {
        image3.SetActive(false);
        image4.SetActive(true);

        batton3.SetActive(false);
        batton4.SetActive(true);
    }
    public void VisibleMonitor4()
    {
        image4.SetActive(false);
        image5.SetActive(true);

        batton4.SetActive(false);
        batton5.SetActive(true);
    }
    public void VisibleMonitor5()
    {
        image5.SetActive(false);
      //  image1.SetActive(true);

        batton5.SetActive(false);
      //  batton1.SetActive(true);


        chek.SetActive(true);
        Chat2.SetActive(true);

       // Handheld.PlayFullScreenMovie("1.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
    }

    public void DeleteNPC()
    {
        NPC.SetActive(false);
        chest.SetActive(true);

        chek.SetActive(false);
    }

    public void PlayVideo1()
    {
        Handheld.PlayFullScreenMovie("1.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
        buttonPlay.SetActive(false);

    }

}
