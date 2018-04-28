using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {

    public GameObject LapCompletetrig;

    public GameObject HalfLapTrig;

    void OnTriggerEnter( )
    {
        LapCompletetrig.SetActive(true);
        HalfLapTrig.SetActive(false);


    }

}
