using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour {

    public int AttackDamage;

    private void OnTriggerEnter(Collider other)
    {
        HUD_Manger hudmanger = other.gameObject.GetComponent<HUD_Manger>();
        if(hudmanger != null)
        {
            hudmanger.UpdateHealth(AttackDamage);
        }
    }

}
	
	

