//Google form class
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
    public partial class Google : Form
    {
        //declare ref vars
        int refCash;
        int refIntel;
        int refTime;
        bool refJob;

        //new work class
        Work work = new Work();
        public Google()
        {
            InitializeComponent();
        }

        //input eryting
        public void inputInfo(ref int cash, ref int intel, ref int time,ref bool job) {
            refCash = cash;
            refIntel = intel;
            refTime = time;
            refJob = job;
        }

        //output eryting
        public void outputInfo(ref int cash, ref int intel, ref int time,ref bool job)
        {
            cash = refCash;
            intel = refIntel;
            time = refTime;
            job = refJob;
        }

        private void btnApplyJob_Click(object sender, EventArgs e)
        {
            if (refJob == false && refIntel >= 100) {
                //if he doesn't work here 
                //now he does
                //set the work here boolean to true
                refJob = true;
                btnApplyJob.Text = "Work";
                //notify the man
                MessageBox.Show("Congratulations! You have been hired as a software engineer at Google!", "Congratulations");
            }
            else if (refJob == true) {
                //make money, 500 dollars per hours, you work 3 hours so he makes 1500
                work.goWork(ref refCash, 500, ref refTime);
                //notify him he gen richer
                MessageBox.Show("You coded for 3 hours straight... You made $1500!", "Good work.");
            }
            else if (refIntel < 100) { 
                //notify him he needa study more
                MessageBox.Show("You need at leat 100 intelligence points to work at Google, so start studying!", "Get smarter");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close this
            this.Close();
        }
    }
}
