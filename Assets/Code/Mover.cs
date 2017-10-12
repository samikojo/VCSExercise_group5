using UnityEngine;

namespace TAMK.VCSExample
{
    public class Mover : MonoBehaviour
    {
        public bool onGround = true;

        public const string JumpAxis = "Jump";

        void Update()
        {
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
    }
}
