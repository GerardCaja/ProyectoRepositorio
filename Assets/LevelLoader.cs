using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public bool optionsIsAccesible;
    public GameObject loadingScreen;
    public GameObject optionsCanvas;


    public void LoadLevel(string nextSceneName)
    {
        StartCoroutine(LoadScene(nextSceneName));
    }

    IEnumerator LoadScene(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        loadingScreen.SetActive(true);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void Update()
    {
    if(Input.GetKeyDown(KeyCode.Escape) && optionsIsAccesible)
        {
            optionsCanvas.SetActive(true);
        }
        
    }

}
