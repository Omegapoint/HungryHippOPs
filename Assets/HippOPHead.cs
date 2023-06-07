using UnityEngine;

public class HippOPHead : MonoBehaviour
{

    private Vector3 _originalPos;
    private float offsetMagnitude = 0;


    // Start is called before the first frame update
    void Start()
    {
        _originalPos = transform.position.CopyVector();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) {
            offsetMagnitude += Constants.HippOPSpeed * Time.deltaTime;
        }
        else if (offsetMagnitude > 0)
        {
            offsetMagnitude -= Constants.HippOPSpeed * Time.deltaTime;
        } 
        transform.position = _originalPos + transform.forward * offsetMagnitude;
    }


}
