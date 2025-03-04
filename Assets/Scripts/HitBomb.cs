using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HitBomb : MonoBehaviour
{
    public GameObject plane;
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bomb"))
        {
            StartCoroutine(GameOver());
            Destroy(other.gameObject);
        }
    }

    IEnumerator GameOver()
    {
        Destroy(plane);
        gameOverText.enabled = true;
        yield return new WaitForSeconds(3);
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
