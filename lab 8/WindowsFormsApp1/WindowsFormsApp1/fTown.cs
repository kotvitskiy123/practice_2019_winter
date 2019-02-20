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
    public partial class fTown : Form
    {
        public Plane ThePlane;
      

        public fTown(Plane t)
        {
            ThePlane = t;
            InitializeComponent();
        }

      

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePlane.Name = tbName.Text.Trim();

            ThePlane.Color = tbColor.Text.Trim();
            ThePlane.Engine = tbEngine.Text.Trim();
            ThePlane.Weight = int.Parse(tbWeight.Text.Trim());
            ThePlane.CountPassengers = int.Parse(tbCountPassengers.Text.Trim());
            ThePlane.CountFuel = int.Parse(tbCountFuel.Text.Trim());
            ThePlane.HasSpecialBagsSection = chbHasPort.Checked;
            ThePlane.IsFull = chbHasAirport.Checked;
            DialogResult = DialogResult.OK;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fTown_Load(object sender, EventArgs e)
        {
            if (ThePlane != null)
            {
                tbName.Text = ThePlane.Name;
                tbColor.Text = ThePlane.Color;
                tbEngine.Text = ThePlane.Engine;
                tbWeight.Text = ThePlane.Weight.ToString();
                tbCountPassengers.Text = ThePlane.CountPassengers.ToString();
                tbCountFuel.Text = ThePlane.CountFuel.ToString();
                chbHasPort.Checked = ThePlane.HasSpecialBagsSection;
                chbHasAirport.Checked = ThePlane.IsFull;
            }
        }

       
    }
}
