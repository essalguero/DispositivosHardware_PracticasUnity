using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour {

    [System.Serializable]
    public struct SistemaTiempo
    {
        public ParticleSystem ps;
        public float tiempo;
    }

    public SistemaTiempo [] sistemas;

    public GameObject prefab;

    // Use this for initialization
    void Start () {
        StartCoroutine(Emite());


        Instantiate(prefab, Vector3.zero, Quaternion.identity);

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    IEnumerator Emite()
    {
        foreach(SistemaTiempo st in sistemas)
        {
            st.ps.Play(); //Arrancamos el sistema de particulas

            yield return new WaitForSeconds(st.tiempo); // Esperamos el tiempo definido

            st.ps.Stop(); // Apagamos el sistema
        }

        
    }
}
