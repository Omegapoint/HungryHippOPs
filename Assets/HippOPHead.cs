using System.Collections.Generic;
using UnityEngine;

public class HippOPHead : MonoBehaviour
{

    public float OffsetMagnitude => offsetMagnitude; 

    private HippOP hippOP;
    private Vector3 _originalPos;
    private float offsetMagnitude = 0;
    private Collider _collider;
    private bool movingInwards = false;
    private List<GameObject> collectedPoints = new List<GameObject>();
    private Controlmap _controlmap;



    void Start()
    {
        hippOP = transform.GetComponentInParent<HippOP>();
        _originalPos = transform.position.CopyVector();
        _collider = GetComponent<Collider>();
        _controlmap = GetComponentInParent<Controlmap>();
    }

    void Update()
    {
        if(_controlmap.CenterKeyPressed && offsetMagnitude < Constants.PLAYER_EXTENSION_MAX && (movingInwards || offsetMagnitude == 0)) {
            movingInwards = true;
            offsetMagnitude += Constants.HippOPSpeed * Time.deltaTime;
            _collider.enabled = false;
        }
        else if (offsetMagnitude > 0)
        {
            movingInwards = false;
            offsetMagnitude -= Constants.HippOPSpeed * Time.deltaTime;
            _collider.enabled = true; // Only enable trigger on way back to eat stuff only on way back
        } else {
            if (collectedPoints.Count > 0) {
                foreach(GameObject point in collectedPoints) {
                    hippOP.IncrementScore();
                    Destroy(point);
                }
            }
            collectedPoints.Clear();
            offsetMagnitude = 0;
            _collider.enabled = false;
        }
        transform.position = _originalPos + transform.forward * offsetMagnitude;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Point")) {
            other.GetComponent<Point>().StickToOther(this.gameObject);
            collectedPoints.Add(other.gameObject);
        }
    }

}
