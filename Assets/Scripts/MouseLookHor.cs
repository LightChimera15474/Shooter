using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookHor : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private void Update()
    {
        var hor = Input.GetAxis("Mouse X") * _speed;

        transform.Rotate(0, hor, 0);
    }
}
