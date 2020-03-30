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
    public partial class Book : Form
    {
        public Book(MainForm MainForm)
        {
            InitializeComponent();
            FormClosing += delegate { MainForm.Close(); };
        }

     
    }
}
