using System;
using UnityEngine;

namespace Utilities
{
    public class RayEmitter : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private MeshRenderer _renderer;
        private Vector3 _pointHit;
        
        
        private void Update()
        {
            if (!Input.GetMouseButtonDown(0)) return;
            
            
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                // length side = 8
                _pointHit = hit.point;
                print($"Hit: {_pointHit}");
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, _pointHit);

            // if (_renderer != null)
            // {
            //     // Bounds bounds = _renderer.bounds;
            //     // Vector3 center = bounds.center;
            //
            //     // Vector3 pointCenterUp = bounds.ClosestPoint(new Vector3(center.x, 0f, center.z));
            //     // Vector3 pointLeftUp = bounds.ClosestPoint(new Vector3(7.5f, 0, center.z));
            //     // Vector3 pointRightUp = bounds.ClosestPoint(new Vector3(-0.5f, 0, center.z));
            //     
            //     // print(center.x);
            //     // float x = 8;
            //     // Gizmos.DrawSphere(center, 0.5f);
            // }
        }
    }
}