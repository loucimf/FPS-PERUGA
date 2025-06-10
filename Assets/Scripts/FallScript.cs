using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FallScript : MonoBehaviour
{
    public TextMeshProUGUI looseText;
    public float deathDistance = -3f;
    public float reloadDelay = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y < deathDistance)
        {
            looseText.enabled = true;
            Debug.Log("Respawn!");
            StartCoroutine(ReloadSceneAfterDelay());
        } else
        {
            looseText.enabled = false;
        }
    }

    IEnumerator ReloadSceneAfterDelay()
    {
        yield return new WaitForSeconds(reloadDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
