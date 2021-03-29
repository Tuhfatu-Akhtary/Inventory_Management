
namespace Inventory_Mangaement
{
    partial class Products_Report
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
            this.inventory_managementdbDataSet2 = new Inventory_Mangaement.inventory_managementdbDataSet2();
            this.Manage_StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Manage_StockTableAdapter = new Inventory_Mangaement.inventory_managementdbDataSet2TableAdapters.Manage_StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_managementdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manage_StockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Products";
            reportDataSource1.Value = this.Manage_StockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory_Mangaement.Products.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(885, 654);
            this.reportViewer1.TabIndex = 0;
            // 
            // inventory_managementdbDataSet2
            // 
            this.inventory_managementdbDataSet2.DataSetName = "inventory_managementdbDataSet2";
            this.inventory_managementdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Manage_StockBindingSource
            // 
            this.Manage_StockBindingSource.DataMember = "Manage_Stock";
            this.Manage_StockBindingSource.DataSource = this.inventory_managementdbDataSet2;
            // 
            // Manage_StockTableAdapter
            // 
            this.Manage_StockTableAdapter.ClearBeforeFill = true;
            // 
            // Products_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 654);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Products_Report";
            this.Text = "Products_Report";
            this.Load += new System.EventHandler(this.Products_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_managementdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manage_StockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Manage_StockBindingSource;
        private inventory_managementdbDataSet2 inventory_managementdbDataSet2;
        private inventory_managementdbDataSet2TableAdapters.Manage_StockTableAdapter Manage_StockTableAdapter;
    }
}