using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Movement
{
    public class MovementScript : MonoBehaviour
    {
        // Start is called before the first frame update
        //[SerializeField] private float _speed;
        [SerializeField] private MovementSettings _movementSettings;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.position += Vector3.forward * _movementSettings.Speed * Time.deltaTime;
            transform.Rotate(Vector3.up, 5 * _movementSettings.Speed * Time.deltaTime);
            //transform.Rotate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}

