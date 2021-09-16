namespace Santier1
{
    partial class PontajControl
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
            this.gridPontaj = new Telerik.WinControls.UI.RadGridView();
            this.radDateTimePickerPontaj = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnSalveazaPontaj = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPontaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPontaj.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerPontaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalveazaPontaj)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPontaj
            // 
            this.gridPontaj.AutoScroll = true;
            this.gridPontaj.BackColor = System.Drawing.SystemColors.Control;
            this.gridPontaj.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPontaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridPontaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridPontaj.Location = new System.Drawing.Point(3, 38);
            // 
            // 
            // 
            this.gridPontaj.MasterTemplate.AllowAddNewRow = false;
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
            this.gridPontaj.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gridPontaj.MasterTemplate.EnableFiltering = true;
            this.gridPontaj.MasterTemplate.EnableGrouping = false;
            this.gridPontaj.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.gridPontaj.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.gridPontaj.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridPontaj.Name = "gridPontaj";
            this.gridPontaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridPontaj.ShowGroupPanel = false;
            this.gridPontaj.Size = new System.Drawing.Size(1275, 325);
            this.gridPontaj.TabIndex = 1;
            this.gridPontaj.ThemeName = "VisualStudio2012Light";
            this.gridPontaj.SizeChanged += new System.EventHandler(this.gridPontaj_SizeChanged);
            // 
            // radDateTimePickerPontaj
            // 
            this.radDateTimePickerPontaj.Location = new System.Drawing.Point(3, 5);
            this.radDateTimePickerPontaj.Name = "radDateTimePickerPontaj";
            this.radDateTimePickerPontaj.Size = new System.Drawing.Size(164, 17);
            this.radDateTimePickerPontaj.TabIndex = 3;
            this.radDateTimePickerPontaj.TabStop = false;
            this.radDateTimePickerPontaj.Text = "Thursday, June 25, 2020";
            this.radDateTimePickerPontaj.Value = new System.DateTime(2020, 6, 25, 23, 29, 34, 119);
            this.radDateTimePickerPontaj.ValueChanged += new System.EventHandler(this.radDateTimePicker1_ValueChanged);
            this.radDateTimePickerPontaj.ValueChanging += new Telerik.WinControls.UI.ValueChangingEventHandler(this.radDateTimePicker1_ValueChanging);
            // 
            // btnSalveazaPontaj
            // 
            this.btnSalveazaPontaj.Location = new System.Drawing.Point(3, 381);
            this.btnSalveazaPontaj.Name = "btnSalveazaPontaj";
            this.btnSalveazaPontaj.Size = new System.Drawing.Size(75, 23);
            this.btnSalveazaPontaj.TabIndex = 4;
            this.btnSalveazaPontaj.Text = "Salveaza";
            // 
            // PontajControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSalveazaPontaj);
            this.Controls.Add(this.radDateTimePickerPontaj);
            this.Controls.Add(this.gridPontaj);
            this.Name = "PontajControl";
            this.Size = new System.Drawing.Size(1108, 518);
            this.Load += new System.EventHandler(this.PontajControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPontaj.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPontaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerPontaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalveazaPontaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridPontaj;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePickerPontaj;
        private Telerik.WinControls.UI.RadButton btnSalveazaPontaj;
    }
}
