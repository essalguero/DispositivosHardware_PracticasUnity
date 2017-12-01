using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoTransitions_14 : MonoBehaviour {

    public AudioSource source;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sonido" )
        {
            source.Play();
            Debug.Log("Trigger Dentro");
        } else
        {
            Debug.Log("Collision Lluvia");
        }

        

        
    }


    void OnTrggerExit (Collider other)
    {
        if (other.gameObject.tag == "Sonido")
        {
            source.Stop();
        }

        Debug.Log("trigger fuera");
    }

    /*void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            source.Play();
        }

        System.Console.WriteLine("Testeando");
    }*/
}
