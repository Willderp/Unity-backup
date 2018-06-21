using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollectable : MonoBehaviour {
    public int points;
    HUD_Manger hudmanger;

	// Use this for initialization
	void Start () {
        hudmanger = GameObject.FindGameObjectWithTag("Player").GetComponent<HUD_Manger>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            gameObject.SetActive(false);
            hudmanger.UpdateScore(points);
        }
    }
}
