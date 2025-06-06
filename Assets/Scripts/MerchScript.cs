using System;
using UnityEngine;

public class MerchScript : MonoBehaviour
{
    public int price = 10;
    public MoneyManager manager;

    private void Start()
    {
        manager = FindFirstObjectByType<MoneyManager>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            manager.UpdateMoney(-price);
            Debug.Log("Player!!!");
            Destroy(gameObject);
        } else {
            Debug.Log("Not player");
        }
    }
}
