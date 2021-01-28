using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ip_converter
{
    public partial class binarytodecimal : UserControl
    {
        public binarytodecimal()
        {
            InitializeComponent();
            label7.Visible = false;
            System.Windows.Forms.ToolTip hover = new System.Windows.Forms.ToolTip();
            hover.SetToolTip(label8, "Click for Copy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n1 = textBox1.Text;
            string n2 = textBox2.Text;
            string n3 = textBox3.Text;
            string n4 = textBox4.Text;
            Regex regex = new Regex("^[0-1]+$");
            List<int> todecimal = new List<int>();

            if (n1.Length != 8 || n2.Length != 8 || n3.Length != 8 || n4.Length != 8)
            {
                label7.Visible = true;
                label6.Text = "The IP Address in Decimal: -";
                label8.Text = "";
            } else if (!regex.IsMatch(n1) || !regex.IsMatch(n2) || !regex.IsMatch(n3) || !regex.IsMatch(n4))
            {
                label7.Visible = true;
                label6.Text = "The IP Address in Decimal: -";
                label8.Text = "";
            } else
            {
                int dec1 = Convert.ToInt32(n1, 2);
                todecimal.Add(dec1);
                int dec2 = Convert.ToInt32(n2, 2);
                todecimal.Add(dec2);
                int dec3 = Convert.ToInt32(n3, 2);
                todecimal.Add(dec3);
                int dec4 = Convert.ToInt32(n4, 2);
                todecimal.Add(dec4);

                label7.Visible = false;
                label6.Text = "The IP Address in Decimal:";
                label8.Text = $"{todecimal[0]}.{todecimal[1]}.{todecimal[2]}.{todecimal[3]}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label7.Visible = false;
            label6.Text = "The IP Address in Decimal: -";
            label8.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label8.Text);
        }

        private void label8_MouseClick(object sender, MouseEventArgs e)
        {
            label8.ForeColor = Color.FromArgb(174, 201, 245);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.White;
        }

        private void label8_MouseUp(object sender, MouseEventArgs e)
        {
        }
    }
}
