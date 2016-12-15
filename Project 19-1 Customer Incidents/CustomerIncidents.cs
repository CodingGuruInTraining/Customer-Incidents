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
    public partial class CustomerIncidents : Form
    {
        public CustomerIncidents()
        {
            InitializeComponent();
        }
         
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techSupport_DataDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Incidents' table. You can move, or remove it, as needed.
            this.incidentsTableAdapter.Fill(this.techSupport_DataDataSet.Incidents);
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.techSupport_DataDataSet.Customers);
            
        }

        //private void fillByCustomerToolStripButton_Click(object sender, EventArgs e)
        //{
            //try
            //{
            //    this.incidentsTableAdapter.FillBy
            //        this.ada
            //    this.customersTableAdapter.fillByCustomer(this.techSupport_DataDataSet.Customers, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox.Text, typeof(int)))));
            //    //this.incidentsTableAdapter
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        //}

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int custCode = (int)(System.Convert.ChangeType(customerIDToolStripTextBox2.Text, typeof(int)));


                this.incidentsTableAdapter.FillBy(this.techSupport_DataDataSet.Incidents, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox1.Text, typeof(int)))));
                this.customersTableAdapter.FillByCust (this.techSupport_DataDataSet.Customers, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox1.Text, typeof(int)))));
                //this.customersTableAdapter.FillTicketByCust(this.techSupport_DataDataSet.Customers, custCode);
                //this.customersTableAdapter.FillByCust(this.techSupport_DataDataSet.Customers, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox2.Text, typeof(int)))));
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        } 

   



        private void fillByCustToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByCust(this.techSupport_DataDataSet.Customers, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox2.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
