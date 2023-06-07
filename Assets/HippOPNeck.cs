using UnityEngine;

public class HippOPNeck : MonoBehaviour
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
            transform.localScale += (Vector3.up * (Constants.HippOPSpeed/2f * Time.deltaTime));
            transform.position +=  (Vector3.forward * (Constants.HippOPSpeed/2f * Time.deltaTime));
        }
        else if (Vector3.Dot(Vector3.forward , offset) > 0)
        {
            transform.localScale -= (Vector3.up * (Constants.HippOPSpeed/2f * Time.deltaTime));
            transform.position -=  (Vector3.forward * (Constants.HippOPSpeed/2f * Time.deltaTime));
        } 
    }
}
