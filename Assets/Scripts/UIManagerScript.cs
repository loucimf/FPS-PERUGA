using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;


public class UIManagerScript : MonoBehaviour
{
    public TextMeshProUGUI moneyTextMesh;
    public TextMeshProUGUI healthTextMesh;
    public TextMeshProUGUI popupTextMesh;

    [FormerlySerializedAs("secondsToWait")] public float secondsToWaitPopup;
    
    public void UpdateMoneyText(string money)
    {
        moneyTextMesh.text = money;
    }

    public void UpdateHealthText(string healthPoints)
    {
        healthTextMesh.text = healthPoints;
    }

    public IEnumerator ShowPopup(string text)
    {
        popupTextMesh.text = text;
        popupTextMesh.enabled = true;
        yield return new WaitForSeconds(secondsToWaitPopup);
        popupTextMesh.enabled = false;
    }
}
