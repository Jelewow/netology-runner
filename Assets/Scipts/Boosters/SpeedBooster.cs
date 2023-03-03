﻿using UnityEngine;

namespace Scipts.Boosters
{
    public class SpeedBooster : MonoBehaviour, IBooster<MonoBehaviour>
    {
        [SerializeField] private float _additionalSpeed;
        [SerializeField] private float _time;

        public float AdditionalSpeed => _additionalSpeed;
        
        public float BoostTime => _time;
        public MonoBehaviour Object => this;
    }
}