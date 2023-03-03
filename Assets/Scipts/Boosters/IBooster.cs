using UnityEngine;

namespace Scipts.Boosters
{
    public interface IBooster<T> where T: MonoBehaviour
    {
        float AdditionalSpeed { get; }
        
        float BoostTime { get; }

        T Object { get; }
    }
}