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
    public partial class TheBay : Form
    {
        //declare ref variable
        int refCash;
        bool bayOwn;
        public TheBay()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (refCash >= 10000)
            {
                //set the bool to true
                bayOwn = true;
                //notify user that he has bought the bay
                MessageBox.Show("You bought the bay for $100 000!", "Congratulations!");
                //take 100 000 dollars away from the kid
                refCash -= 100000;
            }
            else { 
                //tell the user he doesnt have enough to buy it...
                MessageBox.Show("The bay costs $100 000 and you dont have enough. Please come back when you do.", "Make some money.");
            }
        }
        public void inputInfo(ref int cash, ref bool own)
        {
            //converts all info into the class
            refCash = cash;
            bayOwn = own;
        }
        public void outputInfo(ref int cash, ref bool own) { 
            //outputs all info
            cash = refCash;
            own = bayOwn;
        }
    }
}
