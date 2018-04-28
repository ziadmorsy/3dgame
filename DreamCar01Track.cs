using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour {

    public GameObject Marker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public GameObject Mark09;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;
    public GameObject Mark19;
    public int MarkTracker;

    void Update()
    {

        if (MarkTracker == 0)
        {
            Marker.transform.position = Mark01.transform.position;
        }
        if (MarkTracker == 1)
        {
            Marker.transform.position = Mark02.transform.position;
        }
        if (MarkTracker == 2)
        {
            Marker.transform.position = Mark03.transform.position;
        }
        if (MarkTracker == 3)
        {
            Marker.transform.position = Mark04.transform.position;
        }
        if (MarkTracker == 4)
        {
            Marker.transform.position = Mark05.transform.position;
        }
        if (MarkTracker == 5)
        {
            Marker.transform.position = Mark06.transform.position;
        }
        if (MarkTracker == 6)
        {
            Marker.transform.position = Mark07.transform.position;
        }
        if (MarkTracker == 7)
        {
            Marker.transform.position = Mark08.transform.position;
        }
        if (MarkTracker == 8)
        {
            Marker.transform.position = Mark09.transform.position;
        }
        if (MarkTracker == 9)
        {
            Marker.transform.position = Mark10.transform.position;
        }
        if (MarkTracker == 10)
        {
            Marker.transform.position = Mark11.transform.position;
        }
        if (MarkTracker == 11)
        {
            Marker.transform.position = Mark12.transform.position;
        }
        if (MarkTracker == 12)
        {
            Marker.transform.position = Mark13.transform.position;
        }
        if (MarkTracker == 13)
        {
            Marker.transform.position = Mark14.transform.position;
        }
        if (MarkTracker == 14)
        {
            Marker.transform.position = Mark15.transform.position;
        }
        if (MarkTracker == 15)
        {
            Marker.transform.position = Mark16.transform.position;
        }
        if (MarkTracker == 16)
        {
            Marker.transform.position = Mark17.transform.position;
        }
        if (MarkTracker == 17)
        {
            Marker.transform.position = Mark18.transform.position;
        }
        if (MarkTracker == 18)
        {
            Marker.transform.position = Mark19.transform.position;
        }
    }

     IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DreamCar01")
        {
            GetComponent<BoxCollider> ().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 19)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            GetComponent<BoxCollider> ().enabled = true;

        }   
    }
}
