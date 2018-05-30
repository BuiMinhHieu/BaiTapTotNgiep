namespace BuiMinhHieu_CDTH17
{
    partial class InBienLai
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
            this.ReportBienLai = new Microsoft.Reporting.WinForms.ReportViewer();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.BienLaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSInbienlai = new BuiMinhHieu_CDTH17.DSInbienlai();
            this.BienLaiTableAdapter = new BuiMinhHieu_CDTH17.DSInbienlaiTableAdapters.BIENLAITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BienLaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSInbienlai)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportBienLai
            // 
            this.ReportBienLai.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DSinbienlai";
            reportDataSource1.Value = this.BienLaiBindingSource;
            this.ReportBienLai.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportBienLai.LocalReport.ReportEmbeddedResource = "BuiMinhHieu_CDTH17.ReportInBienLai.rdlc";
            this.ReportBienLai.Location = new System.Drawing.Point(0, 38);
            this.ReportBienLai.Name = "ReportBienLai";
            this.ReportBienLai.Size = new System.Drawing.Size(851, 501);
            this.ReportBienLai.TabIndex = 0;
            this.ReportBienLai.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BienLaiBindingSource
            // 
            this.BienLaiBindingSource.DataMember = "BienLai";
            this.BienLaiBindingSource.DataSource = this.DSInbienlai;
            // 
            // DSInbienlai
            // 
            this.DSInbienlai.DataSetName = "DSInbienlai";
            this.DSInbienlai.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BienLaiTableAdapter
            // 
            this.BienLaiTableAdapter.ClearBeforeFill = true;
            // 
            // InBienLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 539);
            this.Controls.Add(this.ReportBienLai);
            this.Name = "InBienLai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InBienLai";
            this.Load += new System.EventHandler(this.InBienLai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BienLaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSInbienlai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportBienLai;
        private System.Windows.Forms.BindingSource BienLaiBindingSource;
        private DSInbienlai DSInbienlai;
        private BuiMinhHieu_CDTH17.DSInbienlaiTableAdapters.BIENLAITableAdapter BienLaiTableAdapter;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}