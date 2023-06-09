using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float secondsLeft = 0;

    public float SecondsLeft => secondsLeft;

    // Start is called before the first frame update
    void Start()
    {
        secondsLeft = Constants.SECONDS_OF_A_ROUND;
    }

    // Update is called once per frame
    void Update()
    {
        if (secondsLeft > 0) {
            secondsLeft -= Time.deltaTime;
        } else {
            secondsLeft = 0;
            GameOver();
        }
    }


    private void GameOver() {
        HippOPsSceneManager.SwitchToEnd();
    }
}
