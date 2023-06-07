using UnityEngine;
using UnityEngine.UIElements;

public class HippOP : MonoBehaviour
{
    private float angleOffset = 0;

    private Vector3 originalForward;

    // Start is called before the first frame update
    void Start()
    {
        originalForward = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            angleOffset += 30 * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            angleOffset -= 30 * Time.deltaTime;
        }

        angleOffset = Mathf.Clamp(angleOffset, -30, 30);
        transform.forward = Quaternion.Euler(new Vector3(0, angleOffset, 0)) * originalForward;
    }
}