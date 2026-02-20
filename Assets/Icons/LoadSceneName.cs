using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneName : MonoBehaviour
{
    public void LoadSceneNamed(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}