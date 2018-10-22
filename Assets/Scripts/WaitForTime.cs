using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForTime : MonoBehaviour {
    public GameObject nps;
    public GameObject dialog;
    public GameObject dialog2;
    // Use this for initialization
    void Start () {
        StartCoroutine(Test());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Test() {
        yield return new WaitForSeconds(15);
        nps.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(Test2());
    }
    IEnumerator Test2()    {
        yield return new WaitForSeconds(5);
        dialog.SetActive(true);
        dialog2.SetActive(true);
        nps.GetComponent<Animator>().SetBool("StopNPC", true);
        StopAllCoroutines();
    }
}
