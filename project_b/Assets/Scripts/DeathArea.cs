using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathArea : MonoBehaviour
{
    public GameObject deathMenuUI;
    bool isDead;
    int index;
    
    // Start is called before the first frame update
    void Start()
    {
        deathMenuUI.SetActive(false);
        isDead = false;
        Time.timeScale = 1;
        index = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("deatharea"))
        {
            deathMenuUI.SetActive(true);
            Time.timeScale = 0;
            isDead = true;
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(index);
        deathMenuUI.SetActive(false);
        Time.timeScale = 1;
        isDead = false;
    }
}
