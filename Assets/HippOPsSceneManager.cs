using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class HippOPsSceneManager
{

  private const string LOGO_SCENE_NAME = "Logo";
  private const string GAME_SCENE_NAME = "Game";
  private const string END_SCENE_NAME = "End";

  private static string currentSceneName = null;


  private static void SwitchToSceneByName(string sceneName)
  {
    if (sceneName != currentSceneName)
    {
      if (currentSceneName != null)
      {
        SceneManager.UnloadSceneAsync(currentSceneName);
      }
      SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
      currentSceneName = sceneName;
    }
  }

  public static void SwitchToGame()
  {
    SwitchToSceneByName(GAME_SCENE_NAME);
  }

  public static void SwitchToEnd()
  {
    SwitchToSceneByName(END_SCENE_NAME);
  }

  public static void SwitchToLogo()
  {
    SwitchToSceneByName(LOGO_SCENE_NAME);
  }


}
