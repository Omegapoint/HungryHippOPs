using UnityEngine;

public class HippOPNeck : MonoBehaviour
{

    public Transform center;
    public Transform origin;
    public float headToNeckOffset = 1;
    private Vector3 _originalPos;
    private Vector3 _originalScale;

    // Start is called before the first frame update
    void Start()
    {
        _originalPos = origin.position.CopyVector();
        _originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        var offset = center.transform.position - _originalPos;
        transform.localScale = _originalScale + (Vector3.up * offset.magnitude / 2) ;
        transform.position = _originalPos + (offset.normalized * ((offset.magnitude / 2) - headToNeckOffset));
    }
}
