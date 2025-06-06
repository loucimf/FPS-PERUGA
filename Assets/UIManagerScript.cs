using TMPro;
using UnityEngine;

public class UIManagerScript : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    public void UpdateMoneyText(string money)
    {
        moneyText.text = money;
    }


}
