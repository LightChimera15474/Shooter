using UnityEngine;

public class MouseLookVert1 : MonoBehaviour
{
    [SerializeField]
    private float _speed = 9f;

    [SerializeField]
    private float _minVert = -45.0f;

    [SerializeField]
    private float _maxVert = 45.0f;

    private float _rotationX = 0;

    private void Update()
    {
        _rotationX -= Input.GetAxis("Mouse Y") * _speed;
        _rotationX = Mathf.Clamp(_rotationX, _minVert, _maxVert);

        var rotationY = transform.localEulerAngles.y;
        transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
    }
}
