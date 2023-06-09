using UnityEngine;
using UnityEngine.UIElements;

public class HippOP : MonoBehaviour
{
    public int playerIndex;
    private float angleOffset = 0;

    private Vector3 originalForward;
    private Controlmap _controlmap;

    // Start is called before the first frame update
    void Start()
    {
        originalForward = transform.forward;
        _controlmap = GetComponent<Controlmap>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_controlmap.LeftKeyPressed)
        {
            angleOffset -= Constants.PLAYER_ROTATION_SPEED_DEGREES_PER_SECOND * Time.deltaTime;
        }
        else if (_controlmap.RightKeyPressed)
        {
            angleOffset += Constants.PLAYER_ROTATION_SPEED_DEGREES_PER_SECOND * Time.deltaTime;
        }

        angleOffset = Mathf.Clamp(angleOffset, -Constants.PLAYER_ROTATION_DEGREES_MAX, Constants.PLAYER_ROTATION_DEGREES_MAX);
        transform.forward = Quaternion.Euler(new Vector3(0, angleOffset, 0)) * originalForward;
    }

    public void IncrementScore() {
        ScoreKeeper.IncrementScoreForPlayer(playerIndex);
    }
}