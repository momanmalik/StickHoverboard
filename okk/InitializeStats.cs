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
    public partial class CreateCharacter : Form
    {
        //declare vars
        //all the initial stats
        int str;
        int charm;
        int intel;
        string name;
        
        //booleans to check if the stats have been initialized
        bool rolled = false; // if player has rolled for stats
        //random 
        Random rand = new Random();
        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                //the rolled var is true because the user has now rolled
                rolled = true;
                //all three stats are picked at random
                str = rand.Next(1, 10);
                charm = rand.Next(1, 10);
                intel = rand.Next(1, 10);
                name = txtName.Text;
                //update labels
                update();
            }
            else {
                //if user has not entered a name, make him do so..
                MessageBox.Show("Please enter your name before proceeding!", "Error!");
            }
        }

        //updates the labels
        public void update() {
            txtChrm.Text = Convert.ToString(charm);
            txtStr.Text = Convert.ToString(str);
            txtIntel.Text = Convert.ToString(intel);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (rolled == true)
            {
                //assigns name to name.text in case the user changed it after rolling
                name = txtName.Text;
                //creates game
                Game game = new Game();
                game.inputInfo(ref name, ref str, ref intel, ref charm);
                
                //close this form and open game
                this.Hide();
                game.FormClosed += (s, args) => this.Close();
                game.Show();
            }
            else {
                MessageBox.Show("You must roll before continuing!", "Error");
            }
        }

        private void panCharCreate_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
