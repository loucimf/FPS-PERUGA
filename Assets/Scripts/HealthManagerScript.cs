using UnityEngine;

public class HealthManagerScript : MonoBehaviour
{
    public int health = 100;
    public UIManagerScript uiManager;

    public void Start()
    {
        uiManager.UpdateHealthText(health.ToString());
    }

    public bool UpdateHealth(int points)
    {
        int resultPoints = health - points;

        if (resultPoints <= 0)
        {
            uiManager.UpdateHealthText("0");
            return false;
        }
        
        health = resultPoints;
        uiManager.UpdateHealthText(health.ToString());
        return true;
    }
}
