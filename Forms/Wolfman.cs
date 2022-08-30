using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop.E2.Forms
{
    public partial class Wolfman : Form
    {
        public Wolfman()
        {
            InitializeComponent();
        }

        string[] weapons = { "ok", "bıçak", "silah", "büyü", "pençe" };
        string[] race = { "Human", "Wolf" };
        string[] branch = { "Assasin", "Warior", "Wizard", "Wolf Man", "Archar" };

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //race
        {
            cmbBranch.Items.Clear();

            if (cmbRace.Text == race[0])
            {
                cmbBranch.Items.Add(branch[0]);
                cmbBranch.Items.Add(branch[1]);
                cmbBranch.Items.Add(branch[2]);
                cmbBranch.Items.Add(branch[4]);
            }
            else
            {
                cmbBranch.Items.Add(branch[3]);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //branch
        {
            cmbWeapon.Items.Clear();

            if (cmbBranch.Text == branch[0])
            {
                cmbWeapon.Items.Add(weapons[1]);
            }

            else if (cmbBranch.Text == branch[1])
            {
                cmbWeapon.Items.Add(weapons[2]);
            }

            else if (cmbBranch.Text == branch[2])
            {
                cmbWeapon.Items.Add(weapons[3]);
            }

            else if (cmbBranch.Text == branch[3])
            {
                cmbWeapon.Items.Add(weapons[4]);
            }

            else 
            {
                cmbWeapon.Items.Add(weapons[0]);
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) //weapon
        {

        }

        private void Wolfman_Load(object sender, EventArgs e)
        {
            cmbRace.Items.Add(race[0]);
            cmbRace.Items.Add(race[1]);
        }
    }
}
