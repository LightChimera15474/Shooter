using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace shoot
{
    public class Magazine : MonoBehaviour
    {

        [SerializeField]
        protected static int _fullMagazine = 30;
        protected int _magazine = _fullMagazine;

        [SerializeField]
        protected Text _ammoLeft;

        protected void reload()
        {
            _magazine = _fullMagazine;
            printAmmoLeft();
        }

        protected void printAmmoLeft()
        {
            _ammoLeft.text = _magazine.ToString();
        }
    }
}

