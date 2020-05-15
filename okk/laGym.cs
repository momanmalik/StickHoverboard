//GYM CLASS
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
    public partial class laGym : Form
    {
        //declare ref vars
        int refTime;
        int refStrength;
        int refHealth;
        int refCash;
        int refIntel;
        int refSpeed;
        bool refMem;
        bool refJob;
        //new work class
        Work work = new Work();
        public laGym()
        {
            InitializeComponent();
        }
        //inputs cash and necessary stats
        public void inputInfo(ref int strength, ref int health, ref int time, ref int cash, ref int intel, ref bool mem, ref bool job) {
            refStrength = strength;
            refHealth = health;
            refCash = cash;
            refTime = time;
            refMem = mem;
            refJob = job;
        }
        //workout method
        public void workOut(ref int strength, int health, ref int time, ref int cash,bool mem) {
            //if you dont have a membership, your health is greater than 50, and the days not over
            if (mem == false && health > 50 && time < 8) {
                //if you have at least 5 dollars
                if (refCash >= 5)
                {
                    //your strength goes up by 2, time goes up by 3 hours, and you lose 5 dollars
                    strength += 2;
                    time++;
                    cash -= 5;
                    //message notifies you what happened
                    MessageBox.Show("You worked out for 3 hours for 5 dollars. You gained 2 strength points", "Progress Report");
                }
                else {
                    //if you dont have at least five dollars, this notifies you
                    MessageBox.Show("You do not have enough money to buy a membership yet. Sorry...", "Go make some money honey.");
                }
            }
            else if (mem = true && health > 50 && time < 8) { //if you do have a membership, your health is greater than 50, and the days not over
                //your strength goes up by 5 and the time goes up by 3 hours
                strength += 5;
                time++;
                //notifies the user of this
                MessageBox.Show("You worked out for 3 hours with a trainer. You gained 5 strength points.", "Progress Report");
            }else if (health <= 50){ //if your healt is under 50 
                //notifies user that he needs some milk
                MessageBox.Show("Your health need to have at least 50hp to workout! Go eat or sleep.", "Slow Down");
            }
            else if (time >= 8) { //if the time is over or equal to 8, the day is over so he cannot do activities
                //notify user that he cant do anything cause the days over
                MessageBox.Show("You cannot work out right now.. your player is too tired.", "Go sleep");
            }
        }
        //output info
        public void outputInfo(ref int strength,ref int health, ref int time, ref int cash,ref bool mem, ref bool job)
        {
            strength = refStrength;
            health = refHealth;
            time = refTime;
            cash = refCash;
            mem = refMem;
            job = refJob;
        }
        //apply button
        private void btnWrkOut_Click(object sender, EventArgs e)
        {
            //wil create membership
            if (refMem == false) //if the user does not have a membership
            {
                //if the users cash is greater than a hundred he can buy a membership
                if (refCash >= 100)
                {
                    //sets the membership bool to true, changes the text of the button to cancel membership
                    refMem = true;
                    btnApply.Text = "Cancel membership";
                    refCash -= 100; //takes the hundred dollar initian fee out of the users pocket
                    btnWrkOut.Text = "Work out with trainer using membership"; //changes the text cause player can now work with trainer
                }
                else {//else if the user does not haev at least a 100
                    //show message box that he is broke... :/
                    MessageBox.Show("You do not have enough money to buy a membership yet. Sorry...", "Go make some money..");
                }
            }else { //if the user does have a membership, this button will be to cancel it
                //set the membership bool to false, change the text of the two buttons
                refMem = false;
                btnWrkOut.Text = "Work out for 3 hours \n Cost: $5";
                btnApply.Text = "Apply for a membership \n $100 initiation fee \n 1$ per day after than \n Trainer included to help you gain extra strength";
            }
        }

        private void btnWrkOut_Click_1(object sender, EventArgs e)
        {
            //this lets him workout
            workOut(ref refStrength, refHealth, ref refTime, ref refCash, refMem);
        }

        private void laGym_Load(object sender, EventArgs e)
        {
            //if he dont work there 
            if (refMem == false)
            {
                //the button should say apply
                btnApply.Text = "Apply";
                btnWrkOut.Text = "Workout w/ trainer";
            }
            else
            {
                //the button say cancel if he work here
                btnApply.Text = "Cancel membership";
                btnWrkOut.Text = "Workout w/ Membership";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exits out the form
            this.Close();
        }

        private void btnApplyJob_Click(object sender, EventArgs e)
        {
            //if the user has a strenght of at least 50, has an intel of at least 20, and does not already work here
            if (refStrength >= 50 && refIntel >= 20 && refJob == false) {
                //he is hired, the bool is set to true
                MessageBox.Show("Congratulations! You've been hired as a personal trainer!");
                refJob = true;
            }
            else if (refJob == true) { //if he already works here
                work.goWork(ref refCash, 30,ref refTime); //he makes money using the work class
            }
            else if (refStrength < 50 && refIntel < 20)
            { //if he does not have enough strength and intel, notify him
                MessageBox.Show("You need at least 50 strength points and at least 20 intelligence points to work here.", "Get stronger and smarter!");
            }
            else if (refStrength < 50)
            {//if player does not have enough strenght points, notify him
                MessageBox.Show("You need at least 50 strength points to work here.", "Get stronger!");
            }
            else if (refIntel < 20)
            {//if player does not have enough intel points, notify him
                MessageBox.Show("You need at least 20 intelligence points to work here.", "Get smarter!");
            }
        }

        private void btnSpdIncrease_Click(object sender, EventArgs e)
        {
            //the player can increase his speed by increments of 2 each time his strength goes up by 10 - he must also have a hundred dollars handy
            if (refStrength >= 20 && refStrength < 30 && refCash >= 100) {
                refSpeed = 8;
                //notifies user of his improvements
                MessageBox.Show("Master Roshi taught you how to run faster! Your speed went up by 2 points.", "YAY");
            }
            else if (refStrength >= 30 && refStrength < 40 && refCash >= 100) {
                refSpeed = 10;
                //notifies user of his improvements
                MessageBox.Show("YMaster Roshi taught you how to run faster! Your speed went up by 2 points.", "YAY");
            }
            else if (refStrength >= 40 && refStrength < 50 && refCash >= 100)
            {
                refSpeed = 12;
                //notifies user of his improvements
                MessageBox.Show("Master Roshi taught you how to run faster! Your speed went up by 2 points.", "YAY");
            }
            else if (refStrength >= 50 && refStrength < 60 && refCash >= 100)
            {
                refSpeed = 14;
                //notifies user of his improvements
                MessageBox.Show("Master Roshi taught you how to run faster! You have unlocked maximum speed!", "Damn you fast as hell now");
            }
            else {// if the user does not have the money or the strength
                //notifies user of his deficiencies
                MessageBox.Show("You need $100 and at least 20 strength points to increase your speed!", "Get stronger and/or get more money!");
            }

        }
    }
}
