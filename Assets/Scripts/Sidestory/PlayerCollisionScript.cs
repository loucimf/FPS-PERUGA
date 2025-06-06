using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionScript : MonoBehaviour
{
    public TextMeshProUGUI loseText;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            loseText.enabled = true;
            Debug.Log("Obstacle!!!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            loseText.enabled = false;
            Debug.Log("No obstacle!!!");
        }
    }
}
