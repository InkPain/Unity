using Gameplay.ShipSystems;
using UnityEngine;

namespace Gameplay.ShipControllers.CustomControllers
{
    public class PlayerShipController : ShipController
    {
        private bool mouseControl = false;
        protected override void ProcessHandling(MovementSystem movementSystem)
        {
            if (mouseControl == false)
            {
                movementSystem.LateralMovement(Input.GetAxis("Horizontal") * Time.deltaTime);
            }
            else
            {
                movementSystem.LateralMovement(Input.GetAxis("Mouse X") * Time.deltaTime);
            }
        }

        protected override void ProcessFire(WeaponSystem fireSystem)
        {
            if (mouseControl == false && Input.GetKey(KeyCode.Space))
            {
                fireSystem.TriggerFire();
            }
            if (mouseControl && Input.GetKey(KeyCode.Mouse0))
            {
                fireSystem.TriggerFire();
            }

            if (mouseControl == false && Input.GetKey(KeyCode.R))
            {
                fireSystem.TriggerRocketFire();
            }
            if (mouseControl && Input.GetKey(KeyCode.Mouse1))
            {
                fireSystem.TriggerRocketFire();
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                if(mouseControl == false)
                {
                    mouseControl = true;
                }
                else
                {
                    mouseControl = false;
                }
            }
        }
    }
}
