using System;
using UnityEngine;

public class BarrrelColliderScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Contacto!");
    }
}
