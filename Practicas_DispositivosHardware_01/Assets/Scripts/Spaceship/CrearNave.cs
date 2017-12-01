using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Globalization;
using System;

public class CrearNave : MonoBehaviour {

    public GameObject spaceShip;

	// Use this for initialization
	void Start () {
        UnityEngine.Random.InitState((int)DateTime.Now.TimeOfDay.Ticks);

        Vector3 position = new Vector3(UnityEngine.Random.Range(-3.0f, 3.0f), UnityEngine.Random.Range(-3.0f, 3.0f), UnityEngine.Random.Range(-3.0f, 3.0f));

        Quaternion rotation = new Quaternion(UnityEngine.Random.Range(-10.0f, 10.0f), UnityEngine.Random.Range(-10.0f, 10.0f), UnityEngine.Random.Range(-10.0f, 10.0f), 1.0f);

        Instantiate(spaceShip, position, rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
