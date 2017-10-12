using UnityEngine;

namespace TAMK.VCSExample
{
    public class Mover : MonoBehaviour
    {

        public bool doRotate;
        public const string HorizontalAxis = "Horizontal";
        public const string VerticalAxis = "Vertical";
        public bool onGround = true;

        public const string JumpAxis = "Jump";

        [SerializeField]
        private float _speed = 4;

        void Update()
        {

            if (Input.GetKey(KeyCode.E))
            {
                Rotate(true);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                Rotate(false);
            }
        

            if (Input.GetKey(KeyCode.Space) && onGround)
            {
                onGround = false;

                transform.Translate(Vector3.up * 0.030f * 100f);
            }
        
            Move();
        }

        private Vector3 GetInputVector()
        {
            float horizontalInput = Input.GetAxis(HorizontalAxis);
            float verticalInput = Input.GetAxis(VerticalAxis);
        

            return new Vector3(horizontalInput, 0.0f, verticalInput);
        }

        protected void OnCollisionStay(Collision collision)
        {
            onGround = true;
        }
        public void Move()
        {
            Vector3 inputVector = GetInputVector();
            Vector3 movementVector = inputVector * _speed;
            transform.Translate(movementVector * Time.deltaTime);
        }
        public void Rotate(bool right)
        {
            if (right)
            {
                transform.Rotate(-5, 0, -5);
            }
            else
            {
                transform.Rotate(5, 5, 5);
            }
            
        }



    }
}
