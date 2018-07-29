using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm
{
    public partial class BackgroundImage : Form
    {

        public BackgroundImage()
        {
            InitializeComponent();
            panelHeader.BackColor = Color.FromArgb(150, 1, 1, 1);
            label3.BackColor = Color.Transparent;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BackgroundImage_Load(object sender, EventArgs e)
        {

        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {

        }
        private bool MouseDown;
        private Point lastLocation;
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            lastLocation = e.Location;
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formCanbo = new FormCanBoQuanLy();
            formCanbo.Show();
            
        }
    }
}
