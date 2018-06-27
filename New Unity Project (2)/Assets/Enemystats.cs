using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemystats : MonoBehaviour {

    public int StartingHealth;
    int CurrentHealth;

	// Use this for initialization
	void Start () {
        CurrentHealth = StartingHealth;
	}
	
	// Update is called once per frame
	public void UpdateHealth(int amount)
    {
        CurrentHealth = CurrentHealth + amount;
        if(CurrentHealth <= 0)
        {
            Death();
        }
	}
    void Death()
    {
        gameObject.SetActive(false);
    }
}
