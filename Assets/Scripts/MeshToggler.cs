using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggler : MonoBehaviour
{
    private GameObject _turbineObject;

    private void Awake()
    {
        _turbineObject = transform.gameObject;
    }

    public void Toggle()
    {
        _turbineObject.SetActive(!_turbineObject.activeInHierarchy);
    }
}
