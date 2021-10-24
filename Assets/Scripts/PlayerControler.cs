using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private void Update()
    {
        var x = Input.GetAxis("Horizontal") * _speed;
        var z = Input.GetAxis("Vertical") * _speed;

        transform.Translate(x, 0, z);
    }
}
