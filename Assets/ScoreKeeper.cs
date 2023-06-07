public static class ScoreKeeper 
{
    private static int[] playerScores = new int[8];

    public static void IncrementScoreForPlayer(int playerIndex) {
        playerScores[playerIndex] = playerScores[playerIndex] + 1;
    }

    public static int GetScoreForPlayer(int playerIndex) {
        return playerScores[playerIndex];
    }

    public static void ResetScores() {
        for (int i = 0; i < playerScores.Length; i++) {
            playerScores[i] = 0;
        }
    }
}
