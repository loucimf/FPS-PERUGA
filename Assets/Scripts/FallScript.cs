using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FallScript : MonoBehaviour
{
    public TextMeshProUGUI looseText;
    public float deathDistance = -4f;
    public float reloadDelay = 2f;

    void Start()
    {
        looseText.enabled = false;
    }

    void Update()
    {
        if (transform.position.y < deathDistance)
        {
            looseText.enabled = true;
            StartCoroutine(ReloadSceneAfterDelay());
        } 
    }

    public void LooseReloadScene()
    {
        looseText.enabled = true;
        StartCoroutine(ReloadSceneAfterDelay());
    }
    
    IEnumerator ReloadSceneAfterDelay()
    {
        yield return new WaitForSeconds(reloadDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        looseText.enabled = false;
    }
}
