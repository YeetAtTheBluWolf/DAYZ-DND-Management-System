﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Nailgun : Weapon, IFirearm, ITool
    {

        public FirearmType FirearmType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Ammo[] Ammo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Nailgun(LootRarity rarity, string name, string description, WeaponType weaponType) : base(rarity, name, description, weaponType)
        {
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }

        public void Utility()
        {
            throw new NotImplementedException();
        }
    }
}