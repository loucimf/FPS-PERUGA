using System;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damage = 10;
    public HealthManagerScript healthManager;
    public FallScript fallScript;

    
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!healthManager.UpdateHealth(damage))
            {
                fallScript.LooseReloadScene();
            };
        }
    }
}
