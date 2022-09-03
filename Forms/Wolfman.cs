using Oop.E2.Classs;
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
        Account account = new Account();
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            cmbRace.Enabled = false;
            cmbBranch.Enabled = false;
            cmbWeapon.Enabled = false;
            btnAttack.Enabled = true;
            pictureBox1.Visible = true;
            lblHealth.Visible = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
            txtUserName.Enabled = true;
            txtUserName.Focus();
            cmbRace.Enabled = true;
            cmbBranch.Enabled = true;
            cmbWeapon.Enabled = true;
            pictureBox1.Visible = false;
            lblHealth.Visible = false;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            account.Attack();
            if (lblHealth.Width <= 300)
            {
                lblHealth.Width -= account.damage;
                MessageBox.Show($"Sevgili {txtUserName.Text},\n {cmbBranch.Text} karakteriyle düşmana {account.damage} hasar verdiniz.");
            }

            if (lblHealth.Width == 0) 
            {
                MessageBox.Show("Bravo Şef.Düşmanı alt ettin.");
                btnAttack.Enabled = false;
                pictureBox1.Visible = false;
                lblHealth.Visible = false;
            }

        }
    }
}
