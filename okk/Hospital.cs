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
    public partial class Hospital : Form
    {
        //ref variables
        int refHealth;
        int refCash;
        int refTime;
        int refIntel;
        bool refJob;
        bool doc;

        Work work = new Work();
        public Hospital()
        {
            InitializeComponent();
        }
        //inputs all necessary info
        public void inputInfo(ref int health, ref int time, ref int cash, ref int intel,ref bool job)
        {
            //ref variables converted
            refHealth = health;
            refCash = cash;
            refTime = time;
            refJob = job;
            refIntel = intel;
        }
        //output info
        public void outputInfo(ref int health, ref int time, ref int cash, ref bool job)
        {
            time = refTime;
            cash = refCash;
            health = refHealth;
            job = refJob;
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            //go to the doctor button
            //if your health is less than 100 and you havent went today - your health goes up by 20 and and 3 hours go by
            if (refHealth < 100 && doc == false)
            {
                refHealth += 20;
                refTime++;
                doc = true;
                //message box notifies you what took place
                MessageBox.Show("You waited for 2 hours for a doctor and he revived you 20 health points!", "Yay");
            }
            //if you the doc bool is true, you already been to the doctor
            else if(doc == true){
                MessageBox.Show("You've already seen the doctor today!", "Sorry..");
            }
            //if ur health is greater than 100 you cant see a doctor
            else if (refHealth >= 100) {
                MessageBox.Show("Your health is already full!", "Your okay.");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //if you dont work here and your intel is greater than 60 you can apply here
            if (refJob = false && refIntel >= 60) {
                refJob = true;
                btnJobApply.Text = "Work";
            }
            else if (refJob == true) {
                //use work class to add cash and spend time
                work.goWork(ref refCash, 150, ref refTime);
                MessageBox.Show("You worked for 3 hours and made $450!", "Your getting richer...");
            }
            else if (refIntel < 60) {
                //if your intelligence is under 60, messagebox 
                MessageBox.Show("You need at least 60 intelligence points to be a doctor!", "Get smarter!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
