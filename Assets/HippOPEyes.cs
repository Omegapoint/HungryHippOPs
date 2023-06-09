using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HippOPEyes : MonoBehaviour
{
    public HippOPHead head;
    private Vector3 _originalPos;
    
    void Start()
    {
        _originalPos = transform.position.CopyVector();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _originalPos + transform.forward * head.OffsetMagnitude;
    }
}
