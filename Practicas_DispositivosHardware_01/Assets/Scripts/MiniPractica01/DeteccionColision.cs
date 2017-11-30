using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionColision : MonoBehaviour {
    int velocidad = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Transform t = GetComponent("PTK_Elevator").transform;

        t.Translate(Vector3.up * velocidad);
    }

    private void OnCollisionEnter(Collision collision)
    {
        velocidad = -2;
    }
}
