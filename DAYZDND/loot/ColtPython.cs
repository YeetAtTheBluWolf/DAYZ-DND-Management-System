﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    internal class ColtPython : Weapon, IFirearm
    {
        public ColtPython(LootRarity rarity, string name, string description, WeaponType weaponType) : base(rarity, name, description, weaponType)
        {
        }

        public FirearmType FirearmType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Ammo[] Ammo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}