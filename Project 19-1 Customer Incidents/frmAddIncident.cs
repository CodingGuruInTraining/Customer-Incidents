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
    public partial class frmAddIncident : Form
    {
        public frmAddIncident()
        {
            InitializeComponent();
        }

        private void customers_AddBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customers_AddBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techSupport_DataDataSet);

        }

        private void frmAddIncident_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Incidents_Add' table. You can move, or remove it, as needed.
            this.incidents_AddTableAdapter.Fill(this.techSupport_DataDataSet.Incidents_Add);
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Products_Add' table. You can move, or remove it, as needed.
            this.products_AddTableAdapter.Fill(this.techSupport_DataDataSet.Products_Add);
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Customers_Add' table. You can move, or remove it, as needed.
            this.customers_AddTableAdapter.Fill(this.techSupport_DataDataSet.Customers_Add);

        }
    }
}
