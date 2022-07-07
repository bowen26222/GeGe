using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public static bool GameIsEnd = false;
    public GameObject endMenuUI;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        endMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsEnd = false;
        index = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("destination"))
        {
            endMenuUI.SetActive(true);
            Time.timeScale = 0;
            GameIsEnd = true;
        }
    }

    public void Next()
    {
        SceneManager.LoadScene(index + 1);
        GameIsEnd = false;
    }

    public void End()
    {
        SceneManager.LoadScene(1);
    }
}
