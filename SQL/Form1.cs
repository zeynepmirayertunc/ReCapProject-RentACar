using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDataSet.Cars);

        }

        private void colorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.colorBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.colorDataSet);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'colorDataSet.Color' table. You can move, or remove it, as needed.
            this.colorTableAdapter.Fill(this.colorDataSet.Color);

        }
    }
}
