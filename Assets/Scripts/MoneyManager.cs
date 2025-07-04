using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float playerMoney;
    public UIManagerScript uiManager;

    public void Start()
    {
        uiManager.UpdateMoneyText(playerMoney.ToString());
    }

    public bool UpdateMoney(float amount)
    {
        if (playerMoney + amount < 0)
        {
            return false;
        }
        
        Debug.Log("Money Updated: " + playerMoney + amount);
        playerMoney += amount;
        uiManager.UpdateMoneyText(playerMoney.ToString());
        return true;
    }
}
