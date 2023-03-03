using System.Collections.Generic;
using Netology.Player;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Scipts.Obstacles
{
    public class ObjectSpawner : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _obstacles;
        [SerializeField] private Vector2 _borders;
        [SerializeField] private Vector2 _distanceBetweenObstacles;
        [SerializeField] private float _offset;
        [Range(1, 6), SerializeField] private int _obstacleAmount;
        [SerializeField] private PlayerMover _playerMover;

        private float _elapsedTime;
        private float _prevPosition;

        private GameObject GetRandomObstacle()
        {
            return _obstacles[Random.Range(0, _obstacles.Count)];
        }

        private void Update()
        {
            _elapsedTime += Time.deltaTime;

            if (_elapsedTime >= 1f)
            {
                _elapsedTime = 0f;

                CreateObstacle(Random.Range(1, _obstacleAmount));
            }
        }

        private void CreateObstacle(int count)
        {
            if (count == 0)
            {
                return;
            }

            GameObject lastObstacle = null;

            for (int i = 0; i < count; i++)
            {
                var x = Random.Range(_borders.x, _borders.y);
                var z = Random.Range(_distanceBetweenObstacles.x, _distanceBetweenObstacles.y) + _offset +
                        _prevPosition + _playerMover.transform.position.z;

                lastObstacle = Instantiate(GetRandomObstacle(), new Vector3(x, 0, z), Quaternion.identity);
            }

            _prevPosition = lastObstacle.transform.position.z;
        }
    }
}