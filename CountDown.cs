using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountDown : MonoBehaviour {

    public GameObject Countdown;
    public AudioSource Getready;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControl;



	void Start () {

        StartCoroutine(CountStart());
        


    }
    IEnumerator CountStart ()
    {
        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<Text>().text = "3";
        Getready.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "2";
        Getready.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "1";
        Getready.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        GoAudio.Play();
        LapTimer.SetActive(true);
        CarControl.SetActive(true);


    }






}
