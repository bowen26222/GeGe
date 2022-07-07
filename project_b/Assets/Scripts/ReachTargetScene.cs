using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReachTargetScene : MonoBehaviour
{
    public int sceneToReach;
    // Start is called before the first frame update
    public void GoToScene()
    {
        SceneManager.LoadScene(sceneToReach);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
