//RPG game 
//Stick RPG - Hoverboard
//Moman Malik
//01/23/2019
//Main Menu
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
    public partial class STICKRPG : Form
    {
        //creates the createcharacter form
        CreateCharacter createCharacter = new CreateCharacter();
        public STICKRPG()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //shows the create character form
            createCharacter.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //creates the help form and shows it
            Help help = new Help();
            help.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //close program
            this.Close();
        }
    }
}
