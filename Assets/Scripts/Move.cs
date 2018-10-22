using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    static bool StopNpc;
    public GameObject FlowChart;
    public GameObject SayDialog;
    // Use this for initialization
    void Start () {
        
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("BoxIn"), "time", 15));
        iTween.RotateAdd(gameObject, iTween.Hash("amount", new Vector3(0,-90,0), "time", 4.8f, "easetype", iTween.EaseType.linear, "looptype", iTween.LoopType.none));
        //iTween.RotateTo(gameObject, iTween.Hash("path", 0.5f, "delay", 4.4f));
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.name == "StopNPC")
        //{
        //    gameObject.GetComponent<Animator>().SetBool("StopNPC", true);
        //    FlowChart.SetActive(true);
        //    SayDialog.SetActive(true);
        //}
    }
}
