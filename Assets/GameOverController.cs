using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            RemoveAllPoints();
            HippOPsSceneManager.SwitchToLogo();
        }
    }

  private void RemoveAllPoints()
  {
    foreach(Point point in FindObjectsOfType<Point>()) {
        Destroy(point.gameObject);
    }
  }
}
