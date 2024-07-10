using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactStudio.PresentationLayer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }


        #region Form Move
        // Create variables to store the mouse coordinates
        private int mouseX;
        private int mouseY;
        private bool mouseDown;

        // When the mouse is pressed inside the Panel
        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            // Set mouseDown to true
            mouseDown = true;
            // Set mouseX and mouseY to the current mouse coordinates
            mouseX = e.X;
            mouseY = e.Y;
        }

        // When the mouse is moved inside the Panel
        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            // If mouseDown is true
            if (mouseDown)
            {
                // Calculate the difference between the current and previous mouse coordinates
                int deltaX = e.X - mouseX;
                int deltaY = e.Y - mouseY;
                // Get the screen bounds
                Rectangle screenBounds = Screen.FromControl(this).Bounds;
                // Get the new location of the Form
                Point newLocation = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
                // Check if the new location is within the screen bounds
                if (newLocation.X >= screenBounds.Left && newLocation.X + this.Width <= screenBounds.Right &&
                    newLocation.Y >= screenBounds.Top && newLocation.Y + this.Height <= screenBounds.Bottom)
                {
                    // Change the location of the Form based on the difference
                    this.Location = newLocation;
                }
            }
        }

        // When the mouse is released inside the Panel
        private void frm_MouseUp(object sender, MouseEventArgs e)
        {
            // Set mouseDown to false
            mouseDown = false;
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAhmad_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/");
        }

        private void btnAmmar_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/");
        }

        private void btnHakam_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/");
        }

        private void btnNour_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/");
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

