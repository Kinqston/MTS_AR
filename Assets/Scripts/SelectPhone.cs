using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPhone : MonoBehaviour {

	// Use this for initialization
	void Start () {

		
	}
    public void SelectApple() {
       // gameObject.SetActive(false);
        Behaviour b = (Behaviour)GetComponent("Halo");
        b.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
