using TMPro;
using UnityEngine;


public class UIManagerScript : MonoBehaviour
{
    public TextMeshProUGUI moneyTextMesh;
    public TextMeshProUGUI healthTextMesh;

    public void UpdateMoneyText(string money)
    {
        moneyTextMesh.text = money;
    }

    public void UpdateHealthPoints(string healthPoints)
    {
        healthTextMesh.text = healthPoints;
    }
}
