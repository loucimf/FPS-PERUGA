using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float playerMoney;
    public UIManagerScript uiManager;

    public bool UpdateMoney(float amount)
    {
        if (playerMoney + amount < 0)
        {
            return false;
        }
        else
        {
            playerMoney += amount;
            uiManager.UpdateMoneyText(playerMoney.ToString());
            return true;
        }
    }
}
