using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BadDesignerLoad
{
    public partial class BadControl : UserControl
    {
        public BadControl()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
            File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "got you.txt"), "Code was run");
        }
    }
}
