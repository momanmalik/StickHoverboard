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
    public partial class TimHortons : Form
    {
        int cost = 0;
        int benefactor = 0;
        int total = 0;
        int refHealth;
        int refCash;
        Size zoom = new Size();
        Size initial = new Size();
        string foodname;
        string foodinfo;
        string rfinfo;
        int refTime;
        Work timsWork = new Work();

        bool work = false;
        public TimHortons()
        {
            InitializeComponent();
            zoom.Width = 158;
            zoom.Height = 103;
            initial.Width = 138;
            initial.Height = 83;
        }

        private void leave_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }
        public void inputInfo(ref int health, ref int cash, ref bool job, ref int time) {
            //converts all info into the class
            refHealth = health;
            refCash = cash;
            work = job;
            refTime = time;
        }
        public void outputInfo(ref int health, ref int cash,ref bool job, ref int time) {
                //health is added, cash is subtracted, rest is outputted
                health += benefactor;
                cash = refCash - cost;
                job = work;
                time = refTime;
           
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (refHealth + benefactor <= 100 && refCash - cost >= 2)
            {
                cost += 2;
                benefactor += 5;
                foodname = "Croissant";
                foodinfo = "Price: $2.00 \n Health: +5";
                recieptUpdate();
            }
            else if (refHealth + benefactor >= 100) {
                MessageBox.Show("Your health is full!", "Purchase incomplete.");
            }
            else if (refCash - cost < 2) {
                MessageBox.Show("You don't have enough money to complete this purchase!", "Purchase incomplete.");
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            foodname = "Croissant";
            foodinfo = "Price: $2.00 \n Health +5";
            info();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            foodname = "";
            foodinfo = "";
            info();

        }

        private void TimHortons_Load(object sender, EventArgs e)
        {
            Color gray = new Color();
            gray = Color.FromArgb(136,139,140);
            foodName.BackColor = gray;
            foodInfo.BackColor = gray;
            reciept.BackColor = gray;

            if (work == true) {
                btnJob.Text = "Work";
            }

        }
        public void goWork(ref int cash,ref int time) {
            refCash += 40;
            time += 4;
        }
        public void info() {
            foodName.Text = foodname;
            foodInfo.Text = foodinfo;
        }

        public void recieptUpdate() {
            reciept.Visible = true;
            rfinfo = foodinfo.Split(':', '\n')[1];
            reciept.Items.Add("You bought: ");
            reciept.Items.Add(foodname + "    " + rfinfo);

        }

        //buy a donut
        private void btnDonut_Click(object sender, EventArgs e)
        {
            if (refHealth + benefactor < 100 && refCash - cost >= 2)
            {
                cost += 1;
                benefactor += 2;
                foodname = "Donut";
                foodinfo = "Price: $1.00 \n Health: +2";
                recieptUpdate();
            }
            else if (refHealth + benefactor >= 100)
            {
                MessageBox.Show("Your health is full!", "Purchase incomplete.");
            }
            else if (refCash - cost < 2)
            {
                MessageBox.Show("You don't have enough money to complete this purchase!", "Purchase incomplete.");
            }
        }

        //buy a sandwich
        private void btnSandwich_Click(object sender, EventArgs e)
        {
            if (refHealth + benefactor < 100 && refCash - cost >= 2)
            {
                cost += 3;
                benefactor += 8;
                foodname = "Sandwich";
                foodinfo = "Price: $3.00 \n Health: +8";
                recieptUpdate();
            }
            else if (refHealth + benefactor >= 100)
            {
                MessageBox.Show("Your health is full!", "Purchase incomplete.");
            }
            else if (refCash - cost < 2)
            {
                MessageBox.Show("You don't have enough money to complete this purchase!", "Purchase incomplete.");
            }
        }

        //buy a coffee
        private void btnCoffee_Click(object sender, EventArgs e)
        {
            if (refHealth + benefactor < 100 && refCash - cost >= 2)
            {
                cost += 2;
                benefactor += 2;
                foodname = "Coffee";
                foodinfo = "Price: $2.00 \n Health: +2";
                recieptUpdate();
            }
            else if (refHealth + benefactor >= 100)
            {
                MessageBox.Show("Your health is full!", "Purchase incomplete.");
            }
            else if (refCash - cost < 2)
            {
                MessageBox.Show("You don't have enough money to complete this purchase!", "Purchase incomplete.");
            }
        }

        //hover donut
        private void btnDonut_MouseEnter(object sender, EventArgs e)
        {
            foodname = "Donut";
            foodinfo = "Price: $1.00 \n Health: +2";
            info();
        }
        private void btnDonut_MouseLeave(object sender, EventArgs e)
        {
            foodname = "";
            foodinfo = "";
            info();
        }

        //hover sandwich
        private void btnSandwich_MouseEnter(object sender, EventArgs e)
        {
            foodname = "Sandiwch";
            foodinfo = "Price: $3.00 \n Health: +8";
            info();
        }
        private void btnSandwich_MouseLeave(object sender, EventArgs e)
        {
            foodname = "";
            foodinfo = "";
            info();
        }

        //hover cofee
        private void btnCoffee_MouseEnter(object sender, EventArgs e)
        {
            foodname = "Croissant";
            foodinfo = "Price: $2.00 \n Health: +5";
            info();
        }
        private void btnCoffee_MouseLeave(object sender, EventArgs e)
        {
            foodname = "";
            foodinfo = "";
            info();
        }

        //show menu button
        private void button1_Click(object sender, EventArgs e)
        {
            if (pMenu.Visible == false)
            {
                foodName.Visible = true;
                foodInfo.Visible = true;
                btnCroissant.Visible = true;
                btnDonut.Visible = true;
                btnSandwich.Visible = true;
                btnCoffee.Visible = true;
                reciept.Visible = true;  
                pMenu.Visible = true;
            }
            else {
                foodName.Visible = false;
                foodInfo.Visible = false;
                btnCroissant.Visible = false;
                btnDonut.Visible = false;
                btnSandwich.Visible = false;
                btnCoffee.Visible = false;
                reciept.Visible = false;
                pMenu.Visible = false;
            }
        }

        //work button
        private void btnJob_Click(object sender, EventArgs e)
        {
            //if the player does not work here, let them apply
            if (work == false)
            {
                //if the day is already over, tell them to come back tomorrow
                if (refTime >= 8)
                {
                    MessageBox.Show("Come back tomorrow, the manager has already left!", "Sorry!");
                }
                //if the day is not over yet, tell them they are hired
                else
                {
                    work = true;
                    MessageBox.Show("Congratulations! You are hired.", "Congratulations");
                    btnJob.Text = "Work";
                }
            }
            else {
                //if they already work here, let them make 10 dollars an hour using the work function
                if (refTime < 8)
                {
                    timsWork.goWork(ref refCash, 10, ref refTime);
                    MessageBox.Show("You worked for three hours and made $30!", "Progress Report");
                }
                else {
                    MessageBox.Show("Come back tomorrow, you are too tired to work!", "Sorry!");
                }
            }
        }
    }
}
