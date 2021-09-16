using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Santier1
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();
            Control angajatiControl = new AngajatiControl();
            radPageView1.Pages[0].Controls.Add(angajatiControl);
            angajatiControl.Dock = DockStyle.Fill;
            angajatiControl.Height = radPageView1.Pages[0].Height;

            Control pontajControl = new PontajControl();
            radPageView1.Pages[1].Controls.Add(pontajControl);
            pontajControl.Dock = DockStyle.Fill;

            Control platiControl = new PlatiControl();
            radPageView1.Pages[2].Controls.Add(platiControl);
            platiControl.Dock = DockStyle.Fill;
        }

    }
}
