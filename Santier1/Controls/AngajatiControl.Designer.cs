namespace Santier1
{
    partial class AngajatiControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridAngajati = new Telerik.WinControls.UI.RadGridView();
            this.btnAngajati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAngajati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAngajati.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAngajati
            // 
            this.gridAngajati.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridAngajati.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            gridViewTextBoxColumn1.FieldName = "EmployeeId";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "EmployeeId";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "FirstName";
            gridViewTextBoxColumn2.HeaderText = "Nume";
            gridViewTextBoxColumn2.Name = "FirstName";
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.FieldName = "LastName";
            gridViewTextBoxColumn3.HeaderText = "Prenume";
            gridViewTextBoxColumn3.Name = "LastName";
            gridViewTextBoxColumn3.Width = 200;
            gridViewTextBoxColumn4.FieldName = "Title";
            gridViewTextBoxColumn4.HeaderText = "Functie";
            gridViewTextBoxColumn4.Name = "Title";
            gridViewTextBoxColumn4.Width = 200;
            gridViewDateTimeColumn1.Expression = "";
            gridViewDateTimeColumn1.FieldName = "HireDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:dd/MM/yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Data angajarii";
            gridViewDateTimeColumn1.Name = "HireDate";
            gridViewDateTimeColumn1.Width = 200;
            gridViewTextBoxColumn5.FieldName = "Address";
            gridViewTextBoxColumn5.HeaderText = "Adresa";
            gridViewTextBoxColumn5.Name = "Address";
            gridViewTextBoxColumn5.Width = 200;
            gridViewTextBoxColumn6.FieldName = "City";
            gridViewTextBoxColumn6.HeaderText = "Oras";
            gridViewTextBoxColumn6.Name = "City";
            gridViewTextBoxColumn6.Width = 200;
            this.gridAngajati.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.gridAngajati.MasterTemplate.EnableFiltering = true;
            this.gridAngajati.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridAngajati.Name = "gridAngajati";
            this.gridAngajati.Size = new System.Drawing.Size(1202, 538);
            this.gridAngajati.TabIndex = 1;
            this.gridAngajati.ThemeName = "VisualStudio2012Light";
            // 
            // btnAngajati
            // 
            this.btnAngajati.Location = new System.Drawing.Point(544, 544);
            this.btnAngajati.Name = "btnAngajati";
            this.btnAngajati.Size = new System.Drawing.Size(118, 27);
            this.btnAngajati.TabIndex = 2;
            this.btnAngajati.Text = "Salveaza";
            this.btnAngajati.UseVisualStyleBackColor = true;
            this.btnAngajati.Click += new System.EventHandler(this.btnAngajati_Click);
            // 
            // AngajatiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAngajati);
            this.Controls.Add(this.gridAngajati);
            this.Name = "AngajatiControl";
            this.Size = new System.Drawing.Size(1202, 576);
            this.Load += new System.EventHandler(this.AngajatiControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAngajati.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAngajati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridAngajati;
        private System.Windows.Forms.Button btnAngajati;
    }
}
