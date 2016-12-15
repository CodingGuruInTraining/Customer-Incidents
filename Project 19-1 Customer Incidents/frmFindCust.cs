using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_19_1_Customer_Incidents
{
    public partial class frmFindCust : Form
    {
        public frmFindCust()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techSupport_DataDataSet);

        }

        private void frmFindCust_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Customers_Find' table. You can move, or remove it, as needed.
            this.customers_FindTableAdapter.Fill(this.techSupport_DataDataSet.Customers_Find);
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.techSupport_DataDataSet.Customers);

        }

        private void fillByStateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customers_FindTableAdapter.FillByState(this.techSupport_DataDataSet.Customers_Find, stateToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
