using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace ip_converter
{
    public partial class decimaltobinary : UserControl
    {
        public decimaltobinary()
        {
            InitializeComponent();
            label7.Visible = false;
            System.Windows.Forms.ToolTip hover = new System.Windows.Forms.ToolTip();
            hover.SetToolTip(label8, "Click for Copy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4;
            List<string> tobinary = new List<string>();
            try
            {
                n1 = Convert.ToInt32(textBox1.Text);
                n2 = Convert.ToInt32(textBox2.Text);
                n3 = Convert.ToInt32(textBox3.Text);
                n4 = Convert.ToInt32(textBox4.Text);

                if (n1.ToString() == "" || n2.ToString() == "" || n3.ToString() == "" || n4.ToString() == "")
                {
                    label7.Visible = true;
                    label6.Text = "The IP Address in Binary: -";
                    label8.Text = "";
                } else if (n1 > 255 || n1 < 0 || n2 > 255 || n2 < 0 || n3 > 255 || n3 < 0 || n4 > 255 || n4 < 0)
                {
                    label7.Visible = true;
                    label6.Text = "The IP Address in Binary: -";
                    label8.Text = "";
                } else
                {
                    label7.Visible = false;
                    string result1 = Convert.ToString(n1, 2);
                    string result2 = Convert.ToString(n2, 2);
                    string result3 = Convert.ToString(n3, 2);
                    string result4 = Convert.ToString(n4, 2);

                    if (result1.Length == 0) tobinary.Add("00000000");
                    else if (result1.Length == 1) tobinary.Add("0000000" + result1);
                    else if (result1.Length == 2) tobinary.Add("000000" + result1);
                    else if (result1.Length == 3) tobinary.Add("00000" + result1);
                    else if (result1.Length == 4) tobinary.Add("0000" + result1);
                    else if (result1.Length == 5) tobinary.Add("000" + result1);
                    else if (result1.Length == 6) tobinary.Add("00" + result1);
                    else if (result1.Length == 7) tobinary.Add("0" + result1);
                    else if (result1.Length == 8) tobinary.Add(result1);

                    if (result2.Length == 0) tobinary.Add("00000000");
                    else if (result2.Length == 1) tobinary.Add("0000000" + result2);
                    else if (result2.Length == 2) tobinary.Add("000000" + result2);
                    else if (result2.Length == 3) tobinary.Add("00000" + result2);
                    else if (result2.Length == 4) tobinary.Add("0000" + result2);
                    else if (result2.Length == 5) tobinary.Add("000" + result2);
                    else if (result2.Length == 6) tobinary.Add("00" + result2);
                    else if (result2.Length == 7) tobinary.Add("0" + result2);
                    else if (result2.Length == 8) tobinary.Add(result2);

                    if (result3.Length == 0) tobinary.Add("00000000");
                    else if (result3.Length == 1) tobinary.Add("0000000" + result3);
                    else if (result3.Length == 2) tobinary.Add("000000" + result3);
                    else if (result3.Length == 3) tobinary.Add("00000" + result3);
                    else if (result3.Length == 4) tobinary.Add("0000" + result3);
                    else if (result3.Length == 5) tobinary.Add("000" + result3);
                    else if (result3.Length == 6) tobinary.Add("00" + result3);
                    else if (result3.Length == 7) tobinary.Add("0" + result3);
                    else if (result3.Length == 8) tobinary.Add(result3);

                    if (result4.Length == 0) tobinary.Add("00000000");
                    else if (result4.Length == 1) tobinary.Add("0000000" + result4);
                    else if (result4.Length == 2) tobinary.Add("000000" + result4);
                    else if (result4.Length == 3) tobinary.Add("00000" + result4);
                    else if (result4.Length == 4) tobinary.Add("0000" + result4);
                    else if (result4.Length == 5) tobinary.Add("000" + result4);
                    else if (result4.Length == 6) tobinary.Add("00" + result4);
                    else if (result4.Length == 7) tobinary.Add("0" + result4);
                    else if (result4.Length == 8) tobinary.Add(result4);

                    label6.Text = "The IP Address in Binary:";
                    label8.Text = $"{tobinary[0]}.{tobinary[1]}.{tobinary[2]}.{tobinary[3]}";
                }

            } catch (Exception)
            {
                label7.Visible = true;
                label6.Text = "The IP Address in Binary: -";
                label8.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label7.Visible = false;
            label6.Text = "The IP Address in Binary: -";
            label8.Text = "";
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
    }
}
