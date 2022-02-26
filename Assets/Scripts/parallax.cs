using System;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public Camera cam;
    public Transform target;
    private Vector2 _startPosition;
    private float _startZ;

    private Vector2 _travel => (Vector2) cam.transform.position - _startPosition;
    private Vector2 _parallaxFactor;

    private void Start()
    {
        _startPosition = transform.position;
        _startZ = transform.position.z;
    }

    public void Update()
    {
        transform.position = _startPosition + _travel;
    }
}
