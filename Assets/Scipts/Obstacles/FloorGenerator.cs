using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Scipts.Obstacles
{
    public class FloorGenerator : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private GameObject _player;
        [SerializeField] private Vector3 _offset;

        private List<GameObject> _floors = new();
        private float _elapsedTime;
        private Vector3 _prevPosition = Vector3.zero;
        
        private void Update()
        {
            _elapsedTime += Time.deltaTime;

            if (_elapsedTime > 2f)
            {
                _elapsedTime = 0f;

                var floor = Instantiate(_prefab, _prevPosition + _offset, Quaternion.identity);
                _prevPosition = floor.transform.position;
                _floors.Add(floor);
            }
        }
    }
}