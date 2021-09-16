namespace Santier1
{
    partial class PlatiControl
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridPlati = new Telerik.WinControls.UI.RadGridView();
            this.radDateTimePickerPlati = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnSalveazaPlati = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlati.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerPlati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalveazaPlati)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPlati
            // 
            this.gridPlati.AutoScroll = true;
            this.gridPlati.BackColor = System.Drawing.SystemColors.Control;
            this.gridPlati.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPlati.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridPlati.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridPlati.Location = new System.Drawing.Point(3, 38);
            // 
            // 
            // 
            this.gridPlati.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "EmployeeId";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "EmployeeId";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Employee";
            gridViewTextBoxColumn2.HeaderText = "Angajat";
            gridViewTextBoxColumn2.Name = "Employee";
            gridViewTextBoxColumn2.Width = 400;
            this.gridPlati.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gridPlati.MasterTemplate.EnableFiltering = true;
            this.gridPlati.MasterTemplate.EnableGrouping = false;
            this.gridPlati.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.gridPlati.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.gridPlati.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridPlati.Name = "gridPlati";
            this.gridPlati.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridPlati.ShowGroupPanel = false;
            this.gridPlati.Size = new System.Drawing.Size(1275, 325);
            this.gridPlati.TabIndex = 1;
            this.gridPlati.ThemeName = "VisualStudio2012Light";
            // 
            // radDateTimePickerPlati
            // 
            this.radDateTimePickerPlati.Location = new System.Drawing.Point(3, 5);
            this.radDateTimePickerPlati.Name = "radDateTimePickerPlati";
            this.radDateTimePickerPlati.Size = new System.Drawing.Size(164, 17);
            this.radDateTimePickerPlati.TabIndex = 3;
            this.radDateTimePickerPlati.TabStop = false;
            this.radDateTimePickerPlati.Text = "Thursday, June 25, 2020";
            this.radDateTimePickerPlati.Value = new System.DateTime(2020, 6, 25, 23, 29, 34, 119);
            // 
            // btnSalveazaPlati
            // 
            this.btnSalveazaPlati.Location = new System.Drawing.Point(3, 381);
            this.btnSalveazaPlati.Name = "btnSalveazaPlati";
            this.btnSalveazaPlati.Size = new System.Drawing.Size(75, 23);
            this.btnSalveazaPlati.TabIndex = 3;
            this.btnSalveazaPlati.Text = "Salveaza";
            // 
            // PlatiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSalveazaPlati);
            this.Controls.Add(this.radDateTimePickerPlati);
            this.Controls.Add(this.gridPlati);
            this.Name = "PlatiControl";
            this.Size = new System.Drawing.Size(1108, 518);
            this.Load += new System.EventHandler(this.PlatiControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPlati.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerPlati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalveazaPlati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridPlati;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePickerPlati;
        private Telerik.WinControls.UI.RadButton btnSalveazaPlati;
    }
}
