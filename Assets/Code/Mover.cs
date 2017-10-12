using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{

        public const string HorizontalAxis = "Horizontal";
        public const string VerticalAxis = "Vertical";

        [SerializeField]
        private float _speed = 4;

        void Update()
		{
            Move();
        }

        private Vector3 GetInputVector()
        {
            float horizontalInput = Input.GetAxis(HorizontalAxis);
            float verticalInput = Input.GetAxis(VerticalAxis);

            return new Vector3(horizontalInput, 0.0f, verticalInput);
        }

        public void Move()
        {
            Vector3 inputVector = GetInputVector();
            Vector3 movementVector = inputVector * _speed;
            transform.Translate(movementVector * Time.deltaTime);
        }
	}
}
