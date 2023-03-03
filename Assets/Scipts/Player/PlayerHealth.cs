using System;
using UnityEngine;

namespace Netology.Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int _healthPoint;

        private int _maxHealth;

        public event Action PlayerDeath;
        
        private void Awake()
        {
            _maxHealth = _healthPoint;
        }

        public void TakeDamage(int damage)
        {
            _healthPoint = Mathf.Clamp(_healthPoint - damage, 0, _maxHealth);
            
            if (_healthPoint == 0)
            {
                PlayerDeath?.Invoke();
                Debug.Log("Ohh bruhhh, you died...");
                Time.timeScale = 0f;
            }
            else
            {
                Debug.Log($"Your take damaged! Current health = {_healthPoint}");
            }
        }
    }
}