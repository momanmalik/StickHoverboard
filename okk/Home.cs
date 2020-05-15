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
    public partial class badHome : Form
    {
        //declare variables
        int refDay;
        int refHealth;
        double refBankCash;
        int refTime;
        bool refGymMem;
        bool refJob;
        bool refOwnBay;
        Random rand = new Random();
        int guala; //how much money he makes from the bay
        public badHome()
        {
            InitializeComponent();
        }
        //inputs info so the variables may be used after as well
        public void inputInfo(ref int day, ref int time, ref int health, ref double bankcash, bool gymMem, bool job, bool ownBay)
        {
            refDay = day;
            refHealth = health;
            refBankCash = bankcash;
            refGymMem = gymMem;
            refTime = time;
            refJob = job;
            refOwnBay = ownBay;
        }
        //outputs info back to the game
        public void outputInfo(ref int day,ref int time, ref int health, ref double bankcash)
        { 
            day = refDay; 
            health = refHealth;
            bankcash = refBankCash;
            time = refTime;
        }
        private void btnSleep_Click(object sender, EventArgs e)
        {
            refDay++;//adds one to the number of days
            refHealth = 100;//restores full health
            refTime = 2; //resets time
            //if the user has a gym membership 
            if (refGymMem == true)
            {
                //he loses a dollar per day
                refBankCash--;
            }

            //if the user works at the bank he gets a higher interest rate
            if (refJob == true)
            {
                refBankCash = (refBankCash * 0.012) + refBankCash;
            }
            else
            {
                refBankCash = (refBankCash * 0.008) + refBankCash;
            }

            //if the user owns the bay he makes money sleeping ahah
            if (refOwnBay == true) {
                guala = rand.Next(800, 1200);
                refBankCash += guala;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }
    }
}
