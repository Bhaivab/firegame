using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_assign1
{
    public partial class Form1 : Form
    {
        //instance object of the functional task 
        functionalTask functionObject = new functionalTask();
        public Form1()
        {
            InitializeComponent();
            //disabled all the button so thus frst of all we must have to start the game 
            btnLoadBullet.Enabled = false;
            btnSpinChamber.Enabled = false;
            btnShoot.Enabled = false;
            btnSHootAway.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //calling the function of the FUnctional class                 
            functionObject.ClkStart(btnStart);
            //print the mesage with instruction
            lblMessage.Text = "Click on Load Bullets ";
            //enable the button to click
            btnLoadBullet.Enabled = true;
        }

        private void btnLoadBullet_Click(object sender, EventArgs e)
        {
            //when we click on load bullet then the chamber load with the bullet
            lblMessage.Text="You have total "+ functionObject.loadBullet() +" Bullets";
            //enable the next button
            btnSpinChamber.Enabled = true;
            //disable itself so thus we can click on next butn
            btnLoadBullet.Enabled = false;
        }

        private void btnSpinChamber_Click(object sender, EventArgs e)
        {
            //enable the next button to shoot and shoot away
            btnShoot.Enabled = true;
            btnSHootAway.Enabled = true;

            //disable itself
            btnSpinChamber.Enabled = false;
            lblMessage.Text = "Click on Shoot to fire ";
            //change the box of picture
            pbBox.Image = FireGame_assign1.Properties.Resources.fire2;
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {

            //click on the shoot button to perform the game 
            functionObject.clkShoot(btnShoot);
        }

        private void btnSHootAway_Click(object sender, EventArgs e)
        {

            //click on the shoot button to perform the game 
            functionObject.clkShtAway(btnSHootAway);

        }
    }
}
