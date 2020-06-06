using System.Collections.Generic;
using Gameplay.Weapons;
using UnityEngine;
using System.Linq;

namespace Gameplay.ShipSystems
{
    public class WeaponSystem : MonoBehaviour
    {

        [SerializeField]
        private List<Weapon> _weapons;

        [SerializeField]
        private List<Weapon> _ultimateWeapons;



        public void Init(UnitBattleIdentity battleIdentity)
        {
            _weapons.ForEach(w => w.Init(battleIdentity));
        }
        
        
        public void TriggerFire()
        {
            _weapons.ForEach(w => w.TriggerFire());
        }

        public void TriggerRocketFire()
        {
            _ultimateWeapons.ForEach(w => w.TriggerRocketFire());
        }

    }
}
