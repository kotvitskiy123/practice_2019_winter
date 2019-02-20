using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fMain : Form
    {
       

        public fMain()
        {
            InitializeComponent();
        }

     

        private void btnAddPlane_Click(object sender, EventArgs e)
        {
            Plane plane = new Plane();
            fTown ft = new fTown(plane);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbTownsInfo.Text += string.Format("Name: {0}, Color:  {1}, Engine: {2}, Weight: {3}, CountPassengers: {4},  CountFuel: {5},   [{6} | {7}] \n", plane.Name, plane.Color, plane.Engine, plane.Weight, plane.CountPassengers, plane.CountFuel, plane.HasSpecialBagsSection ? "Has special bag section" : "No special bag section", plane.IsFull ? "Is full " : "Not full");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)  Application.Exit();
        }

       
    }
}
