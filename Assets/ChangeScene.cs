using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    
    public void GoToScene (string sceneName)
    {
        Debug.Log("My method is called!");
        SceneManager.LoadScene(sceneName);
    }

}
