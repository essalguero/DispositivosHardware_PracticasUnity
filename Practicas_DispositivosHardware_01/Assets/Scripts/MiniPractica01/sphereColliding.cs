using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereColliding : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collider other)
    {
        if(other.gameObject.name == "Esfera02")
        {
            System.Console.WriteLine("Detectando la colision");
        }
    }
}
