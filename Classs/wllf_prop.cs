using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.E2.Classs
{
    internal class Account
    {
        public string userName { get; set; }
        public string race { get; set; }
        public string weapon { get; set; }
        public int damage { get; set; }
        public string branch { get; set; }

        //{ "Assasin", "Warior", "Wizard", "Wolf Man", "Archar" };

        public void Attack()
        {
            damage = 0;
            Random rndmDamage = new Random();

            if (branch == "Assasin")
            {
                damage += 60;
            }
            else if (branch == "Warior")
            {
                damage += rndmDamage.Next(45, 61);
            }

            else if (branch == "Wizard")
            {
                damage += rndmDamage.Next(50, 76);
            }

            else if (branch == "Wolf Man")
            {
                damage += 65;
            }
            else
            {
                damage += rndmDamage.Next(30, 61);
            }
        }
    }
}
