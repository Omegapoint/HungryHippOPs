
using UnityEngine;

public class HippOPHead : MonoBehaviour
{
    public float Speed = 5;
    public float HeadTravelDistance = 20;
    
    private Vector3 _originalPos;

    // Start is called before the first frame update
    void Start()
    {
        _originalPos =  CopyVector(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        var offset = transform.position - _originalPos;

        if(Input.GetKey(KeyCode.Space)) {
            transform.position += (Vector3.forward * (Speed * Time.deltaTime));
        }
        else if (Vector3.Dot(Vector3.forward , offset) > 0)
        {
            transform.position -= (Vector3.forward * (Speed * Time.deltaTime));
        } 
    }

    private Vector3 CopyVector(Vector3 input)
    {
        return new Vector3(x: input.x, y: input.y, z: input.z);
    }
}
