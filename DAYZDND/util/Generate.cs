using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.util
{
    public class Generate
    {

        public static void ResidentalLoot()
        {

        }

        public static void CommercialLoot()
        {

        }
        
        public static void WeaponLoot()
        {

        }

        public static void HardwareLoot()
        {

        }

        public static void MedicalLoot()
        {

        }

        public static int ChanceRoll(int max)
        {
            var roll = RandomNumberGenerator.GetInt32(0, max);
            Console.WriteLine("You rolled a {0}", roll);
            return roll;
        }

        public static int AccuRoll()
        {
            return RandomNumberGenerator.GetInt32(0, 101);
        }

    }
}
