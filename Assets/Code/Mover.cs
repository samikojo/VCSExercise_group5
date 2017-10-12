using UnityEngine;

namespace TAMK.VCSExample
{
    public class Mover : MonoBehaviour
    {
        public bool doRotate;


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
