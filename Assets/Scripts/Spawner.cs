using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Monster;
    public float TimeToSpawn;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(Spawn());
	}
	
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeToSpawn);
            Instantiate(Monster, transform.position, transform.rotation);
        }
    }
}
