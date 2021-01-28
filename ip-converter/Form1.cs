using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ip_converter
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            decimaltobinary1.BringToFront();
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.FromArgb(174, 201, 245);
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            button3.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button1.Top;
            SidePanel.Height = button1.Height;
            decimaltobinary1.BringToFront();
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.FromArgb(174, 201, 245);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button2.Top;
            SidePanel.Height = button2.Height;
            binarytodecimal1.BringToFront();
            button2.ForeColor = Color.White;
            button1.ForeColor = Color.FromArgb(174, 201, 245);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(0, 126, 249);
            //54; 50; 207
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Red;
        }
    }
}
