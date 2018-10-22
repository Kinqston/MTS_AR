using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    public GameObject Main;
    public GameObject Vac;
    public GameObject Vac1;

    public void MainView()
    {
        Main.SetActive(false);
        Vac.SetActive(true);
    }

    public void VacView()
    {
        Vac.SetActive(false);
        Vac1.SetActive(true);
    }

    public void loadLevl()
    {
        Destroy(gameObject);
        Application.LoadLevel("mtc");
    }
    // Use this for initialization
    void Start () {
		//Screen.orientation = ScreenOrientation.Portrait;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
