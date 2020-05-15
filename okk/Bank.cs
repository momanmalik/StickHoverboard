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
    public partial class Bank : Form
    {
        //declare ref variables
        int refCash;
        bool refJob;
        int refTime;
        double refBankCash;
        int refIntel;
        int amount;
        Work bankWork = new Work();
        public Bank()
        {
            InitializeComponent();
        }
        //inputs all info into class
        public void inputInfo(ref int cash, ref double bankCash, ref int intel, ref bool job, ref int time) {
            //converts all info into the class
            refJob = job;
            refCash = cash;
            refTime = time;
            refBankCash = bankCash;
            refIntel = intel;
        }
        //outputs all info back to og class
        public void outputInfo(ref int cash, ref double bankCash, ref bool job, ref int time)
        {
            job = refJob;
            cash = refCash;
            time = refTime;
            bankCash = refBankCash;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //deposit button adds to the bank cash and takes from users cash
            if (refCash - amount >= 0) //makes sure you haev money to deposit
            {
                amount = Convert.ToInt32(numAmount.Value);
                refBankCash += amount;
                refCash -= amount;
                lblBalance.Text = Convert.ToString(refBankCash);
            }
        }

        private void btnWthdrw_Click(object sender, EventArgs e)
        {
            //withdraw button takes from the bank cash and gives to users cash
            if (refBankCash - amount >= 0) //makes sure you have money in the bank to withdraw
            {
                amount = Convert.ToInt32(numAmount.Value);
                refBankCash -= amount;
                refCash += amount;
                lblBalance.Text = Convert.ToString(refBankCash);
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            //exits form
            this.Close();
        }

        private void btnApplyJob_Click(object sender, EventArgs e)
        {
            if (refTime >= 2 && refTime <= 7) //user can apply and work between 6:00 and 21:00
            {
                //if user meets requirements assign him the job
                if (refJob == false && refIntel >= 30)
                {
                    refJob = true;
                    //set the text to work since he can now
                    btnApplyJob.Text = "Work";
                    //notifies him he got the job
                    MessageBox.Show("Congratulations! You have been hired as a bankteller!");
                }
                //if user has the job
                else if (refJob == true)
                {
                    //uses work class to make money
                    bankWork.goWork(ref refCash, 25, ref refTime);
                    //messagebox shows that he worked
                    MessageBox.Show("You worked 3 hours and made $75!", "Good work...");
                }
                //if the user does not meet the rquirements
                else if (refIntel < 30)
                {
                    //message box explains issue
                    MessageBox.Show("You need at least 30 intelligence points to work here...", "Get smarter..");
                }
            }
            else {
                //notify user to come back later
                MessageBox.Show("Please come back between 6:00 and 21:00", "Come back later.");
            }
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            //shows users balance 
            lblBalance.Text = Convert.ToString(refBankCash);

            //when the game loads check to see if the user already works here
            if (refJob == true)
            {
                //if he has the job this button should say work
                btnApplyJob.Text = "Work";
            }
            else {
                //if he does not have the job it should say apply
                btnApplyJob.Text = "Apply";
            }
        }
    }
}
