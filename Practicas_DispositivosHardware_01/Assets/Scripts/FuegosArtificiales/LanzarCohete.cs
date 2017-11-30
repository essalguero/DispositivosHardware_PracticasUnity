using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarCohete : MonoBehaviour {

    public ParticleSystem lanzador01;
    public ParticleSystem lanzador02;
    public ParticleSystem lanzador03;
    public ParticleSystem lanzador04;
    public ParticleSystem lanzador05;
    public ParticleSystem lanzador06;

    private ParticleSystem[] arraySistemas = new ParticleSystem[6];

    // Use this for initialization
    void Start () {
        Random.InitState(50);

        arraySistemas[0] = lanzador01;
        arraySistemas[1] = lanzador02;
        arraySistemas[2] = lanzador03;
        arraySistemas[3] = lanzador04;
        arraySistemas[4] = lanzador05;
        arraySistemas[5] = lanzador06;


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        
        


        if (Input.GetKeyDown(KeyCode.Space))
        {

            StartCoroutine(Lanzar());

        }
    }

    IEnumerator Lanzar()
    {

        int numeroLanzador = (int)Random.Range(0.0f, 5.9f);        

        if (numeroLanzador == 1 || numeroLanzador == 2)
        {
            Debug.Log("Numero buscado");
        }

        arraySistemas[numeroLanzador].Emit(1);

        yield return new WaitForSeconds(1);
    }
}
