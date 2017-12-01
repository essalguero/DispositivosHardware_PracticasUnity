using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacecraftController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Rotate(new Vector3(0, 0, -30) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.Rotate(new Vector3(30, 0, 0) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.Rotate(new Vector3(-30, 0, 0) * Time.deltaTime);

        }

    }
}
