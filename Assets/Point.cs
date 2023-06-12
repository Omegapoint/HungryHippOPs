using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
  public Material takenMaterial;
  Rigidbody _rigidbody;
  Collider _collider;
  // Start is called before the first frame update
  void Start()
  {
    _rigidbody = GetComponent<Rigidbody>();
    _collider  =GetComponent<Collider>();
  }

  // Update is called once per frame
  void Update()
  {
    if (_rigidbody != null && transform.position.y < 1/* So it doesn't "sway" if in the air*/)
    {
      Vector3 forceTowardsCenter = new Vector3(-transform.position.x, 0, -transform.position.z).normalized * Constants.POINT_FORCE_TOWARDS_CENTER;
      _rigidbody.AddForce(forceTowardsCenter);
    }
  }

  public void StickToOther(GameObject other)
  {
    Destroy(_rigidbody);
    Destroy(_collider);
    _rigidbody = null;
    transform.parent = other.transform;
    GetComponent<MeshRenderer>().material = takenMaterial;
  }
}