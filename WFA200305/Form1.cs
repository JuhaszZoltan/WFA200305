using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA200305
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbMuvelet.SelectedIndex = 0;
            tbX.TextChanged += cbMuvelet_SelectedIndexChanged;
            tbY.TextChanged += cbMuvelet_SelectedIndexChanged;
        }

        private void cbMuvelet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tbX.Text != "" && tbY.Text != "")
            {
                try
                {
                    int x = int.Parse(tbX.Text);
                    int y = int.Parse(tbY.Text);
                    string er = null;

                    switch (cbMuvelet.SelectedItem)
                    {
                        case "+": er = $"= {x + y}"; break;
                        case "-": er = $"= {x - y}"; break;
                        case "*": er = $"= {x * y}"; break;
                        case "/": er = $"= {x / y}"; break;
                    }
                    lblEredmeny.Text = er;
                }
                catch(DivideByZeroException)
                {
                    lblEredmeny.Text = "HIBA";
                    MessageBox.Show("nullával sajnos nem lehet osztani :(");
                }
                catch(FormatException)
                {
                    lblEredmeny.Text = "HIBA";
                    MessageBox.Show("Számokat írj be légyszíves!");
                }

            }
        }
    }
}
