using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Literature.View
{
    public partial class InternetResource : Form
    {
        public InternetResource(MainForm MainForm)
        {
            InitializeComponent();
            FormClosing += delegate { MainForm.Close(); };
        }

       
    }
}
