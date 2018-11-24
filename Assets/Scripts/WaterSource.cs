using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSource : MonoBehaviour {
    public GameObject waterPrefabs;
    private bool isSpawnSession = false;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if(isSpawnSession == false)
        StartCoroutine(SpawnRoutine());
    }


    IEnumerator SpawnRoutine()
    {
        isSpawnSession = true;
        Instantiate(waterPrefabs, new Vector3(0, 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.2f);
        isSpawnSession = false;
    }
}
