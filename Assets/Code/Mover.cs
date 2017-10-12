using UnityEngine;

namespace TAMK.VCSExample
{
    public class Mover : MonoBehaviour
    {
        public bool doRotate;
        public bool onGround = true;

        public const string JumpAxis = "Jump";

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
        }

        protected void OnCollisionStay(Collision collision)
        {
            onGround = true;
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
