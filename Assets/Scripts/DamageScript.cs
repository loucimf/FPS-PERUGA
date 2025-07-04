using System;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damage = 10;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
        }
    }
}
