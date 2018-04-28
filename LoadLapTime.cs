using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadLapTime : MonoBehaviour
{

    public int MiniCount;
    public int SecCount;
    public float MilliCount;

    public GameObject MIniDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;







    // Use this for initialization
    void Start()
    {

        MiniCount = PlayerPrefs.GetInt("MiniSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetFloat("MilliSave");


        MIniDisplay.GetComponent<Text>().text = "" + MiniCount+":";
        SecDisplay.GetComponent<Text>().text = "" + SecCount+".";
        MilliDisplay.GetComponent<Text>().text = "" + MilliCount;


    }

}