﻿namespace Project_19_1_Customer_Incidents
{
    partial class CustomerIncidents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerIncidents));
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupport_DataDataSet = new Project_19_1_Customer_Incidents.TechSupport_DataDataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewIncident = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerIDToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.customerIDToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSrchState = new System.Windows.Forms.ToolStripButton();
            this.customersTableAdapter = new Project_19_1_Customer_Incidents.TechSupport_DataDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Project_19_1_Customer_Incidents.TechSupport_DataDataSetTableAdapters.TableAdapterManager();
            this.incidentsTableAdapter = new Project_19_1_Customer_Incidents.TechSupport_DataDataSetTableAdapters.IncidentsTableAdapter();
            this.customerIDToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.customerIDToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByCustToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByCustToolStrip = new System.Windows.Forms.ToolStrip();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillByCustToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 39);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 91);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 117);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(79, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City, State, Zip:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(12, 143);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 169);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(95, 36);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.techSupport_DataDataSet;
            // 
            // techSupport_DataDataSet
            // 
            this.techSupport_DataDataSet.DataSetName = "TechSupport_DataDataSet";
            this.techSupport_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(95, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(296, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(95, 88);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(296, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(95, 114);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(138, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(239, 114);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(31, 20);
            this.stateTextBox.TabIndex = 10;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(276, 114);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(115, 20);
            this.zipCodeTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(95, 140);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(95, 166);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(296, 20);
            this.emailTextBox.TabIndex = 16;
            // 
            // incidentsDataGridView
            // 
            this.incidentsDataGridView.AutoGenerateColumns = false;
            this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.incidentsDataGridView.DataSource = this.incidentsBindingSource;
            this.incidentsDataGridView.Location = new System.Drawing.Point(15, 227);
            this.incidentsDataGridView.Name = "incidentsDataGridView";
            this.incidentsDataGridView.Size = new System.Drawing.Size(645, 137);
            this.incidentsDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateOpened";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateOpened";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateClosed";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateClosed";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn6.HeaderText = "Title";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 300;
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "Incidents";
            this.incidentsBindingSource.DataSource = this.techSupport_DataDataSet;
            // 
            // btnNewIncident
            // 
            this.btnNewIncident.Location = new System.Drawing.Point(511, 376);
            this.btnNewIncident.Name = "btnNewIncident";
            this.btnNewIncident.Size = new System.Drawing.Size(110, 23);
            this.btnNewIncident.TabIndex = 17;
            this.btnNewIncident.Text = "Add New Incident";
            this.btnNewIncident.UseVisualStyleBackColor = true;
            this.btnNewIncident.Click += new System.EventHandler(this.btnNewIncident_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel1,
            this.customerIDToolStripTextBox1,
            this.fillByToolStripButton,
            this.toolStripSeparator1,
            this.btnSrchState});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(680, 25);
            this.fillByToolStrip.TabIndex = 19;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // customerIDToolStripLabel1
            // 
            this.customerIDToolStripLabel1.Name = "customerIDToolStripLabel1";
            this.customerIDToolStripLabel1.Size = new System.Drawing.Size(73, 22);
            this.customerIDToolStripLabel1.Text = "CustomerID:";
            // 
            // customerIDToolStripTextBox1
            // 
            this.customerIDToolStripTextBox1.Name = "customerIDToolStripTextBox1";
            this.customerIDToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(34, 22);
            this.fillByToolStripButton.Text = "Find";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSrchState
            // 
            this.btnSrchState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSrchState.Image = ((System.Drawing.Image)(resources.GetObject("btnSrchState.Image")));
            this.btnSrchState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSrchState.Name = "btnSrchState";
            this.btnSrchState.Size = new System.Drawing.Size(91, 22);
            this.btnSrchState.Text = "Search By State";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Customers_FindTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.IncidentsTableAdapter = this.incidentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project_19_1_Customer_Incidents.TechSupport_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDToolStripLabel2
            // 
            this.customerIDToolStripLabel2.Name = "customerIDToolStripLabel2";
            this.customerIDToolStripLabel2.Size = new System.Drawing.Size(73, 22);
            this.customerIDToolStripLabel2.Text = "CustomerID:";
            // 
            // customerIDToolStripTextBox2
            // 
            this.customerIDToolStripTextBox2.Name = "customerIDToolStripTextBox2";
            this.customerIDToolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByCustToolStripButton
            // 
            this.fillByCustToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByCustToolStripButton.Name = "fillByCustToolStripButton";
            this.fillByCustToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.fillByCustToolStripButton.Text = "FillByCust";
            this.fillByCustToolStripButton.Click += new System.EventHandler(this.fillByCustToolStripButton_Click);
            // 
            // fillByCustToolStrip
            // 
            this.fillByCustToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel2,
            this.customerIDToolStripTextBox2,
            this.fillByCustToolStripButton});
            this.fillByCustToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByCustToolStrip.Name = "fillByCustToolStrip";
            this.fillByCustToolStrip.Size = new System.Drawing.Size(680, 25);
            this.fillByCustToolStrip.TabIndex = 20;
            this.fillByCustToolStrip.Text = "fillByCustToolStrip";
            // 
            // CustomerIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 419);
            this.Controls.Add(this.fillByCustToolStrip);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnNewIncident);
            this.Controls.Add(this.incidentsDataGridView);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Name = "CustomerIncidents";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillByCustToolStrip.ResumeLayout(false);
            this.fillByCustToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TechSupport_DataDataSet techSupport_DataDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private TechSupport_DataDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private TechSupport_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private TechSupport_DataDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private System.Windows.Forms.DataGridView incidentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnNewIncident;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox customerIDToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox customerIDToolStripTextBox2;
        private System.Windows.Forms.ToolStripButton fillByCustToolStripButton;
        private System.Windows.Forms.ToolStrip fillByCustToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSrchState;
    }
}

