namespace Inventory_Mangaement
{
    partial class Books_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.inventory_managementdbDataSet1 = new Inventory_Mangaement.inventory_managementdbDataSet1();
            this.Book_EntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Book_EntryTableAdapter = new Inventory_Mangaement.inventory_managementdbDataSet1TableAdapters.Book_EntryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_managementdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_EntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Books";
            reportDataSource1.Value = this.Book_EntryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory_Mangaement.Books.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(860, 655);
            this.reportViewer1.TabIndex = 0;
            // 
            // inventory_managementdbDataSet1
            // 
            this.inventory_managementdbDataSet1.DataSetName = "inventory_managementdbDataSet1";
            this.inventory_managementdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Book_EntryBindingSource
            // 
            this.Book_EntryBindingSource.DataMember = "Book_Entry";
            this.Book_EntryBindingSource.DataSource = this.inventory_managementdbDataSet1;
            // 
            // Book_EntryTableAdapter
            // 
            this.Book_EntryTableAdapter.ClearBeforeFill = true;
            // 
            // Books_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 655);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Books_Report";
            this.Text = "Books_Report";
            this.Load += new System.EventHandler(this.Books_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_managementdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_EntryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Book_EntryBindingSource;
        private inventory_managementdbDataSet1 inventory_managementdbDataSet1;
        private inventory_managementdbDataSet1TableAdapters.Book_EntryTableAdapter Book_EntryTableAdapter;
    }
}