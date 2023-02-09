namespace DAYZDND.loot;

using System;

public interface IFirearm
{

    public FirearmType FirearmType { get; set; }
    public Ammo[] Ammo { get; set; }

    public void Shoot();

}
