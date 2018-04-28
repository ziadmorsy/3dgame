using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColor : MonoBehaviour {

    public GameObject RedBody;
    public GameObject BlueBody;
    public int CarImport;

	// Use this for initialization
	void Start () {

        CarImport = GlobalCar.CarType;
        if (CarImport == 1)
        {
            RedBody.SetActive(true);
        }
        else
        {
            BlueBody.SetActive(true);
        }
	}
	
}
