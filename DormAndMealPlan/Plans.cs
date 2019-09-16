using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMealPlan
{
    public partial class Plans : Form
    {
        public Plans()
        {
            InitializeComponent();
        }

        int DormCharges;
        int MealCharges;

        private void radioButtonAllenHall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAllenHall.Checked)
            {
                DormCharges = 1500;
            }
        }

        private void radioButtonPikeHall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPikeHall.Checked)
            {
                DormCharges = 1600;
            }
        }

        private void radioButtonFarthingHall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFarthingHall.Checked)
            {
                DormCharges = 1800;
            }
        }

        private void radioButtonUniversitySuites_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUniversitySuites.Checked)
            {
                DormCharges = 2500;
            }
        }

        private void radioButton7Meals_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7Meals.Checked)
            {
                MealCharges = 600;
            }
        }

        private void radioButton14Meals_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14Meals.Checked)
            {
                MealCharges = 1200;
            }
        }

        private void radioButtonUnlimitedMeals_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUnlimitedMeals.Checked)
            {
                MealCharges = 1700;
            }
        }
    }
}
