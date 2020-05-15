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
    public partial class University : Form
    {
        //ref variables
        int refCash;
        int refTime;
        int refIntel;
        bool refJob;
        Work professor = new Work();
        public University()
        {
            InitializeComponent();
        }
        public void inputInfo(ref int time, ref int cash, ref int intel, ref bool job)
        {
            //ref variables converted
            refCash = cash;
            refTime = time;
            refJob = job;
            refIntel = intel;
        }
        //output info
        public void outputInfo(ref int time, ref int cash, ref int intel, ref bool job)
        {
            time = refTime;
            cash = refCash;
            intel = refIntel;
            job = refJob;
        }
        //study method
        public void study(int level, ref int intel, ref int time, ref int cash) {
            if (refTime >= 3 && refTime <= 6)// you cant study from 9 to 6
            {
                //level one of studying is tutor
                if (level == 1)
                {
                    //your intelligence goes up by 2 in 3 hours
                    intel += 2;
                    time++;
                    cash -= 10;
                    MessageBox.Show("You attending a tutoring session for 10 dollars and your intelligence went up by 2!", "Your smarter now...");
                }
                else if (level == 2)
                {
                    //level two of studying is attending a lecture
                    //your intelligence goes up by 6 in 3 hours
                    intel += 6;
                    time++;
                    cash -= 30;
                    MessageBox.Show("You attending a lecture for $30 and your intelligence went up by 6!", "Your smarter now...");
                }
            }
            else {
                //if you are here before 9 or after 6, it notifies you to come back later
                MessageBox.Show("Please come back during 9:00 to 18:00.", "Come back later.");
            }
        }
        private void btnTutor_Click(object sender, EventArgs e)
        {
            //study at level 1 
            study(1,ref refIntel,ref refTime, ref refCash);
        }

        private void btnLecture_Click(object sender, EventArgs e)
        {
            //study at level 2
            study(2, ref refIntel, ref refTime, ref refCash);
        }

        //apply for a job
        private void btnJobApply_Click(object sender, EventArgs e)
        {
            if (refTime >= 3 && refTime <= 6) //if the time is in between 9 and 18:00
            {
                //if the user does not already work here and his intelligence is greather than or equal to 45
                if (refJob == false && refIntel >= 45)
                {
                    //he starts working here
                    refJob = true;
                    //the btn text gets changed
                    btnJobApply.Text = "Work";
                    //notify user that he works here now
                    MessageBox.Show("Congratulations! You have been hired to teach at the University of Toronto!", "Congratulations!");
                }
                else if (refIntel < 45) { 
                    //if the user does not have enough intelligence just let him know
                    MessageBox.Show("You are not smart enough to work here yet.. You need at least 45 intelligence points to work here.", "Keep studying.");
                }
                else if (refJob == true) //if the user does work here
                {
                    //he works using the work class making 100 dollars per 3 hours
                    professor.goWork(ref refCash, 100, ref refTime);
                    //notify user what he just done
                    MessageBox.Show("You taught students for 3 hours and made $300.", "Good work");
                }
            }
            else {
                //tell user to come back later..
                MessageBox.Show("Please come back during 9:00 to 18:00.", "Come back later.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit form
            this.Close();
        }
    }
}
