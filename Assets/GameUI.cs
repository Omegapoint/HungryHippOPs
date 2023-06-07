
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public List<TMP_Text> playerScoreTexts;

    public List<TMP_Text> timerTexts;

    public GameManager gameManager;

    void Update() {
        for (int i = 0; i < playerScoreTexts.Count; i++) {
            playerScoreTexts[i].text = "" + ScoreKeeper.GetScoreForPlayer(i);
        }

        for (int i = 0; i < timerTexts.Count; i++) {
            TimeSpan timeSpan = TimeSpan.FromSeconds(gameManager.SecondsLeft);
            string timeText = string.Format("{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            timerTexts[i].text = timeText;
        }
    }

}
