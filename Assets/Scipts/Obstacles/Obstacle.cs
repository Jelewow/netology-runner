using UnityEngine;

namespace Scipts.Obstacles
{
    public class Obstacle : MonoBehaviour
    {
        [SerializeField] private int _damage;

        public int Damage => _damage;
    }
}