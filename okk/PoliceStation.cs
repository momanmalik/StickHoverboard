
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okk
{
    public partial class PoliceStation : Form
    {
        //declare ref vars
        int refTime;
        int refStrength;
        int refCash;
        int refIntel;
        bool refJob;

        //create new work class
        Work pO = new Work();
        public PoliceStation()
        {
            InitializeComponent();
        }

        //inputs info
        public void inputInfo(ref int strength,ref int time, ref int cash, ref int intel, ref bool job)
        {
            refStrength = strength;
            refCash = cash;
            refTime = time;
            refIntel = intel;
            refJob = job;
        }
        //output info
        public void outputInfo(ref int strength, ref int time, ref int cash, ref int intel, ref bool job) {
            strength = refStrength;
            time = refTime;
            cash = refCash;
            intel = refIntel;
            job = refJob;
        }
        private void btnJobApply_Click(object sender, EventArgs e)
        {
            //if it is between 6 and 24:00 
            if (refTime >= 2 && refTime < 8)
            {
                //if the user does not work there
                if (refJob == false && refStrength >= 30 && refIntel >= 30)
                {
                    refJob = true;
                    btnJobApply.Text = "Work";
                    MessageBox.Show("You have been hired as a police officer!", "Congratulations!");
                }
                else if (refStrength < 30)
                {
                    //notify user that he needs at least 30 strength points to work here
                    MessageBox.Show("You need to have at least 30 strength points to be a police officer.", "Come back when you are stronger.");
                }
                else if (refIntel < 30)
                {
                    //notify user that he needs at least 30 intel points to work here
                    MessageBox.Show("You need to have at least 30 intelligence points to be a police officer.", "Come back when you are smarter.");
                }
                else if (refStrength < 30 && refIntel < 30)
                {
                    //notify user that he needs at least 30 strength and intelligence points to work here
                    MessageBox.Show("You need to have at least 30 strength and intelligence points to be a police officer.", "Come back when you are stronger and smarter.");
                }
                else if (refJob == true)
                { //this is the one where he works
                    //the work classed is used here
                    pO.goWork(ref refCash, 50, ref refTime);
                }
            }
            else { //if there is not enough time
                //notify user that he needa sleep
                MessageBox.Show("Go sleep, partner. We'll need you tomorrow", "Go home.");
            }
        }
    }
}
