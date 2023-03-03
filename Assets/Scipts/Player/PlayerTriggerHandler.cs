using Scipts.Boosters;
using Scipts.Obstacles;
using UnityEngine;

namespace Netology.Player
{
    public class PlayerTriggerHandler : MonoBehaviour
    {
        [SerializeField] private PlayerHealth _playerHealth;
        [SerializeField] private PlayerMover _playerMover;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Obstacle obstacle))
            {
                _playerHealth.TakeDamage(obstacle.Damage);
                obstacle.gameObject.SetActive(false);
                return;
            }

            if (other.gameObject.TryGetComponent(out IBooster<MonoBehaviour> booster))
            {
                _playerMover.BoostSpeed(booster.AdditionalSpeed, booster.BoostTime);
                booster.Object.gameObject.SetActive(false);
            }
        }
    }
}