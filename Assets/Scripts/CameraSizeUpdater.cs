using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera)), ExecuteInEditMode]

public class CameraSizeUpdater : MonoBehaviour
{
    private Camera _camera;

    private enum BaseType
    {
        Both,Width,Height
    }

    [SerializeField]
    private BaseType _baseType = BaseType.Both;

    [SerializeField]
    private float _baseWidth = 1280, _baseHeight = 1920;

    [SerializeField]
    private float _pixelPerUnit = 100f;

    [SerializeField]
    private bool _isAlwaysUpdate = false;

    private float _currentAspect;

    private void Awake()
    {
        UpdateOrthographicSize();
    }
    private void OnValidate()
    {
        _currentAspect = 0;
        UpdateOrthographicSize();
    }
    private void Update()
    {
        if(!_isAlwaysUpdate && Application.isPlaying)
        {
            return;
        }
        UpdateOrthographicSize();
    }
    private void UpdateOrthographicSize()
    {
        float currentAspect = (float)Screen.height / (float)Screen.width;
        if (Mathf.Approximately(_currentAspect, currentAspect))
        {
            return;
        }
        _currentAspect = currentAspect;

        if (_camera == null)
        {
            _camera = gameObject.GetComponent<Camera>();
        }
        float baseAspect = _baseHeight / _baseWidth;
        float baseOrthographicSize = _baseHeight / _pixelPerUnit / 4f;

        if(_baseType == BaseType.Height || (baseAspect > _currentAspect && _baseType != BaseType.Width))
        {
            _camera.orthographicSize = baseOrthographicSize;
        }
        else
        {
            _camera.orthographicSize = baseOrthographicSize * (_currentAspect / baseAspect);
        }
    }

}
