using UnityEngine;

public class HippOPNeck : MonoBehaviour
{

    public HippOPHead head;
    private Vector3 _originalPos;
    private Vector3 _originalScale;

    // Start is called before the first frame update
    void Start()
    {
        _originalPos = transform.position.CopyVector();
        _originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        var offset = head.transform.position - _originalPos;
        transform.localScale = _originalScale + (Vector3.up * offset.magnitude / 2) ;
        transform.position = _originalPos + (offset / 2);
    }
}
