using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*void LateUpdate()
    {

        int valorX = 0;

        if (Input.GetKey("a"))
        {
            valorX += 10;
        }

        if (Input.GetKey("D"))
        {
            valorX -= 10;
        }


        transform.position = new Vector3(Input.GetAxis("Horizontal") + (valorX * Time.deltaTime), transform.position.y, transform.position.z);

        Input.GetAxis("Horizontal");
        Input.GetAxis("Vertical");
    }*/

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.Translate(new Vector3(0, 0, 10) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.Translate(new Vector3(0, 0, -10) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(new Vector3(-10, 0, 0) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(new Vector3(10, 0, 0) * Time.deltaTime);

        }

    }
}
