using UnityEngine;

public class HippOPHead : MonoBehaviour
{

    private Vector3 _originalPos;

    // Start is called before the first frame update
    void Start()
    {
        _originalPos = transform.position.CopyVector();
    }

    // Update is called once per frame
    void Update()
    {
        var offset = transform.position - _originalPos;

        if(Input.GetKey(KeyCode.Space)) {
            transform.position += (Vector3.forward * (Constants.HippOPSpeed * Time.deltaTime));
        }
        else if (Vector3.Dot(Vector3.forward , offset) > 0)
        {
            transform.position -= (Vector3.forward * (Constants.HippOPSpeed * Time.deltaTime));
        } 
    }


}
