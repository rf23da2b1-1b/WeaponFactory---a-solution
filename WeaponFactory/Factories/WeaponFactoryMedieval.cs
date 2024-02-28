using System;
using System.Security.Cryptography;
using WeaponFactory.Interfaces;
using WeaponFactory.Weapons;

namespace WeaponFactory.Factories
{
    /// <summary>
    /// Weapon factory class for medieval weapons.
    /// </summary>
    public class WeaponFactoryMedieval : IWeaponFactory
    {
        public IWeapon Create(WeaponType type)
        {
            IWeapon weapon = null;
            switch (type)
            {
                case WeaponType.Magic: weapon =  new Wand(); 
                    break;
                case WeaponType.Melee: weapon = new Dagger();
                    break;
                case WeaponType.Ranged: weapon = new CrossBow();
                    break;
            }
            

            return weapon;
        }
    }
}