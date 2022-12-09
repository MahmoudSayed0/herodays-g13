using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableScript : MonoBehaviour
{


    [SerializeField] private Transform _intereactionPoint;
    [SerializeField] private float _intereactionPointRadius = 0.5f;
    [SerializeField] private LayerMask _intereactionMask;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numFound;


    void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_intereactionPoint.position, _intereactionPointRadius, _colliders, _intereactionMask);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(_intereactionPoint.position, _intereactionPointRadius);

    }
}
