using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuasiFoamQuantumStateGUI
{
    public partial class FormQuasiFoamQuantumStateGUI : System.Windows.Forms.Form
    {
        public FormQuasiFoamQuantumStateGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelHolographicLayer_Click(object sender, EventArgs e)
        {

        }

        private void buttonToggleQFQSModel1_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the QFQS model 1

            pictureBoxQFQS1.Visible = !pictureBoxQFQS1.Visible;
        }

        private void buttonWSF2_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the Wheeler space foam model 2

            pictureBoxWSF2.Visible = !pictureBoxWSF2.Visible;
        }

        private void buttonQFQS2_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the QFQS model 2

            pictureBoxQFQS2.Visible = !pictureBoxQFQS2.Visible;
        }

        private void buttonQFQS3_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the QFQS model 3

            pictureBoxQFQS3.Visible = !pictureBoxQFQS3.Visible;
        }

        private void buttonHolographicLayer1_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the holographic layer 1

            pictureBoxHL1.Visible = !pictureBoxHL1.Visible;
        }

        private void buttonHL2_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the holographic layer 2

            pictureBoxHL2.Visible = !pictureBoxHL2.Visible;
        }

        private void buttonInformationFlow1_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the information flow 1

            pictureBoxIF1.Visible = !pictureBoxIF1.Visible;
        }

        private void buttonIF2_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the information flow 2

            pictureBoxIF2.Visible = !pictureBoxIF2.Visible;
        }

        private void buttonWheelerSpaceFoam1_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the Wheeler space foam 1

            pictureBoxWSF1.Visible = !pictureBoxWSF1.Visible;
        }

        private void buttonWSF3_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the Wheeler space foam model 3

            pictureBoxWSF3.Visible = !pictureBoxWSF3.Visible;
        }

        private void buttonSpinNetworkLayer_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the spin network layer 1

            pictureBoxSN1.Visible = !pictureBoxSN1.Visible;
        }

        private void buttonSN2_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the spin network layer 2

            pictureBoxSN2.Visible = !pictureBoxSN2.Visible;
        }
    }
}
