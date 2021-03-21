using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowPlants_Click(object sender, EventArgs e)
        {
            Roses myroses = new Roses();
            myroses.Leafcolor = "green"; 
            myroses.Name = "English"; 
            myroses.Origin = "England"; 
            lbplants.Items.Add("====ROSES===="); 
            lbplants.Items.Add(myroses.Leafcolor); 
            lbplants.Items.Add(myroses.Name); 
            lbplants.Items.Add(myroses.Origin);
        }
    }
}
