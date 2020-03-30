using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Literature.View;

namespace Literature
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ComboBoxSelected.SelectedIndex = 0;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            switch(ComboBoxSelected.SelectedIndex)
            {
                case 0: 
                {
                    Book book = new Book(this);
                    book.Show();
                    Hide();
                    break;
                }
                case 1:
                {
                    MagazineArticle article = new MagazineArticle(this);
                    article.Show();
                    Hide();
                    break;
                }
                case 2:
                {
                    DigestArticle article = new DigestArticle(this);
                    article.Show();
                    Hide();
                    break;
                }
                case 3:
                {
                    NewspaperArticle article = new NewspaperArticle(this);
                    article.Show();
                    Hide();
                    break;
                }
                case 4:
                {
                    Dissertation dis = new Dissertation(this);
                    dis.Show();
                    Hide();
                    break;
                }
                case 5:
                {
                    Abstract abs = new Abstract(this);
                    abs.Show();
                    Hide();
                    break;
                }
                case 6:
                {
                    InternetResource res = new InternetResource(this);
                    res.Show();
                    Hide();
                    break;
                }
                default:
                break;
            }
           
        }

      
    }
}
