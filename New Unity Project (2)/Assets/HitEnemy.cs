using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour {

    public int AttackDamage;

	// Use this for initialization
	private void OnTriggerEnter(Collider other)
    {
        Enemystats enemystats = other.gameObject.GetComponent<Enemystats>();

        if (enemystats != null)
        {
            enemystats.UpdateHealth(AttackDamage);
        }
		
	}
	
}
