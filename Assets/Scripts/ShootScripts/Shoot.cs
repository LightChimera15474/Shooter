using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


namespace shoot
{
    public class Shoot : Magazine
    {
        [SerializeField]
        private float _damage = 2.0f;

        [SerializeField]
        private float _range = 50.0f;

        [SerializeField]
        private Camera _camera;

        [SerializeField]
        private Text _scoreText;

        private int _score { get; set; }

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1") && _magazine != 0)
            {
                shoot();
            }
            if (Input.GetKey(KeyCode.R) && _magazine < _fullMagazine)
            {
                reload();
            }

        }

        private void shoot()
        {
            var point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            Ray ray = _camera.ScreenPointToRay(point);

            _magazine--;

            if (Physics.Raycast(ray, out var hit, _range) && hit.transform.CompareTag("Target"))
            {
                Debug.Log(hit.transform.name);
                Destroy(hit.transform.gameObject);

                _score++;
                _scoreText.text = _score.ToString();

            }

            printAmmoLeft();
        }

    }
}

