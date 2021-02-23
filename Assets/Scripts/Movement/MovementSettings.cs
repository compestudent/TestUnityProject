using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Movement
{
    [CreateAssetMenu(menuName = "Movement/MovementSettings/Setting1")]
    public class MovementSettings : ScriptableObject
    {
        [SerializeField] private float _speed;
        public float Speed { get { return _speed; } }
    }
}
