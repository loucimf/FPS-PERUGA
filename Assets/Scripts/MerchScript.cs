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
            if (manager.UpdateMoney(-price))
            {
                Destroy(gameObject);
            };
            Debug.Log("Player!!!");
        } else {
            Debug.Log("Not player");
        }
    }
}
