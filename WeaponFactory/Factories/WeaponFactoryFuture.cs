using System;
using WeaponFactory.Interfaces;
using WeaponFactory.Weapons;

namespace WeaponFactory.Factories
{
    /// <summary>
    /// Weapon factory class for futuristic weapons.
    /// </summary>
    public class WeaponFactoryFuture : IWeaponFactory
    {
        public IWeapon Create(WeaponType type)
        {
            switch (type)
            {
                case WeaponType.Magic: return new VacuumEnergyChanneler();
                case WeaponType.Melee: return new TazerKnuckles();
                case WeaponType.Ranged: return new Phaser();
            }
            return null;
        }
    }
}