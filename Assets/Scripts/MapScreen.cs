using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapScreen : MonoBehaviour
{
    public void StartLevel1()
    {
        SceneManager.LoadSceneAsync(SceneIDs.gameSceneID);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
