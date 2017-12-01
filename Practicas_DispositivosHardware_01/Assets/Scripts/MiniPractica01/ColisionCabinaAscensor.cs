using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionCabinaAscensor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        System.Console.WriteLine("Testeando");
    }
}
