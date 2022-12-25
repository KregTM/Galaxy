using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void CloseGame()
    {
        Application.Quit();
    }

    public void ReplayLevel()
    {
        SceneManager.LoadSceneAsync(SceneIDs.gameSceneID);
    }

    public void ReturnToMap()
    {
        SceneManager.LoadSceneAsync(SceneIDs.mapSceneID);
    }
}
