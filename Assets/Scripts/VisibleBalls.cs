using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleBalls : MonoBehaviour
{
    public GameObject buttonPlay;
    public GameObject[] ball;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void VisibleBall()
    {
        for (int i = 0; i < 6; i++)
        {
            ball[i].SetActive(true);
        }
        buttonPlay.SetActive(true);
    }
}
