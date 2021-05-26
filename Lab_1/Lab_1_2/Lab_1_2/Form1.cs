using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < Controls.Count; i++)
            {
                var control = Controls[i];
                if (control is Label)
                {
                    Controls.Remove(control);
                }
            }

        }
    }
}
