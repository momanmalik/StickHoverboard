using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;
namespace okk
{
    public partial class Game : Form
    {

        //declare vars
        int speed = 6;

        //stats
        int health;
        int charm;
        int intel;
        int strength;
        int cash = 100;
        double bankcash = 0;//amount of money user has in the bank
        int day = 0; //number of ingame days user spent
        string name = "";
        //movement
        bool goleft = false;
        bool goright = false;
        bool goup = false;
        bool godown = false;

        int time = 0;

        //which activity is open
        bool timsO = false;
        bool homeO = false;

        //where do u have a job
        bool timJob = false;
        bool pizJob = false;
        bool gooJob = false;
        bool hosJob = false;
        bool uniJob = false;
        bool bnkJob = false;
        bool gymJob = false;
        bool gymMem = false;
        bool polJob = false;
        bool bayOwn = false; //if the user owns the bay
        public Game()
        {
            InitializeComponent();
            health = 50;
            time = 2;
        }
        private void Game_Load(object sender, EventArgs e)
        {
            //initialize the stats
            update();
            exit("home");
        }
        public void inputInfo(ref string inName,ref int inStrength,ref int inIntel,ref int inCharm) { 
            //takes the info from the create character form and inputs them here
            name = inName;
            strength = inStrength;
            intel = inIntel;
            charm = inCharm;
        }
        //KEY DOWN
        public void Game_KeyDown(object sender, KeyEventArgs e)
        {
            //check to see if player hit anything
            check();
            //if the A key is pressed
            if (e.KeyCode == Keys.A)
            {
                //move left
                goleft = true;
                move();
            }
            //if the D key is pressed
            else if (e.KeyCode == Keys.D)
            {
                //move right
                goright = true;
                move();
            }
            //if the W key is pressed
            else if (e.KeyCode == Keys.W)
            {
                //move up
                goup = true;
                move();
            }
            //if the S key is pressed
            else if (e.KeyCode == Keys.S)
            {
                //move down
                godown = true;
                move();
            }

        }

        public void Game_KeyUp(object sender, KeyEventArgs e)
        {
            //check to see if player hit anything
            check();
            //if the A key is pressed
            if (e.KeyCode == Keys.A)
            {
                //stop moving
                goleft = false;
                player.Image = Properties.Resources.ppIdle;
                move();

            }
            //if the D key is pressed
            else if (e.KeyCode == Keys.D)
            {
                //stop moving
                goright = false;
                player.Image = Properties.Resources.ppIdle;
                move();
            }
            //if the W key is pressed
            else if (e.KeyCode == Keys.W)
            {
                //stop moving
                goup = false;
                player.Image = Properties.Resources.ppIdle;
                move();
            }
            //if the S key is pressed
            else if (e.KeyCode == Keys.S)
            {
                //stop moving
                godown = false;
                player.Image = Properties.Resources.ppIdle;
                move();
            }

        }

        public void move()
        {
            //moves the whole map in the desired direction
            if (godown == true)
            {
                moveMap("down");
                player.Image = Properties.Resources.ppdown;
            }
            if (goup == true)
            {
                moveMap("up");

                player.Image = Properties.Resources.ppup;
            }
            if (goright == true)
            {
                moveMap("right");

                player.Image = Properties.Resources.ppright;

            }
            if (goleft == true)
            {
                moveMap("left");

                player.Image = Properties.Resources.ppleft;

            }
        }

        //moves map in the desired direction
        public void moveMap(string direction) {
            //move down
            if (direction == "down") {
                bg.Top -= speed;
                picTims.Top -= speed;
                picHome.Top -= speed;
                picBank.Top -= speed;
                picBay.Top -= speed;
                picGgl.Top -= speed;
                picGym.Top -= speed;
                picHosp.Top -= speed;
                picTtc.Top -= speed;
                picPoll.Top -= speed;
                picPol.Top -= speed;
                picPiz.Top -= speed;
                picUot.Top -= speed;
            }
            //move up
            if (direction == "up") {
                bg.Top += speed;
                picTims.Top += speed;
                picHome.Top += speed;
                picBank.Top += speed;
                picBay.Top += speed;
                picGgl.Top += speed;
                picGym.Top += speed;
                picHosp.Top += speed;
                picTtc.Top += speed;
                picPoll.Top += speed;
                picPol.Top += speed;
                picPiz.Top += speed;
                picUot.Top += speed;
            }
            //move right
            if (direction == "right") {
                bg.Left -= speed;
                picTims.Left -= speed;
                picHome.Left -= speed;
                picBank.Left -= speed;
                picBay.Left -= speed;
                picGgl.Left -= speed;
                picGym.Left -= speed;
                picHosp.Left -= speed;
                picTtc.Left -= speed;
                picPoll.Left -= speed;
                picPol.Left -= speed;
                picPiz.Left -= speed;
                picUot.Left -= speed;
            }
            //move left
            if (direction == "left") {
                bg.Left += speed;
                picTims.Left += speed;
                picHome.Left += speed;
                picBank.Left += speed;
                picBay.Left += speed;
                picGgl.Left += speed;
                picGym.Left += speed;
                picHosp.Left += speed;
                picTtc.Left += speed;
                picPoll.Left += speed;
                picPol.Left += speed;
                picPiz.Left += speed;
                picUot.Left += speed;
            }
        }
        public void check() {
            //tims enter
            if(player.Bounds.IntersectsWith(picTims.Bounds)){
                if (timsO == false) //check if tims form is open, if tims is closed
                {
                    //makes the boolean true, meaning tims is open
                    timsO = true;
                    //hides the character so it seems as if he entered the tims
                    player.Visible = false; 

                    //creates new tim hortons form
                    TimHortons timHortons = new TimHortons(); 
                    //shows tim hortons form
                    timHortons.inputInfo(ref health, ref cash, ref timJob, ref time);
                    timHortons.ShowDialog();                   

                    //this code is ran only after the timhorton form is closed
                    //make player visible again
                    player.Visible = true;
                    //update labels
                    
                    timHortons.outputInfo(ref health, ref cash, ref timJob, ref time);
                    stopmove(); // resets all the movement bools 
                    move();
                    update();
                    //makes the tims boolean false, meaning that it is closed
                    timsO = false;
                    //this relocates the character at the tim's entrance
                    exit("tims");
                }
            }
            //home enter
            if(player.Bounds.IntersectsWith(picHome.Bounds)){
                if (homeO == false) { // if home form is not open - open it
                    homeO = true; //makes boolean true
                    player.Visible = false; //hides character

                    //creates the form 
                    badHome badhome = new badHome();
                    badhome.inputInfo(ref day,ref time, ref health, ref bankcash, gymMem, bnkJob, bayOwn); //inputs the necessary info
                    badhome.ShowDialog();
                    badhome.outputInfo(ref day,ref time, ref health, ref bankcash);

                    //show player;
                    player.Visible = true;
                    //update labels
                    update();

                    //makes home boolean false, meaning that its closed
                    homeO = false;
                    //spawns character outside of tims
                    exit("home");
                    
                }
            }
            //gym enter
            if(player.Bounds.IntersectsWith(picGym.Bounds)){
                //new gym class
                laGym lagym = new laGym();
                //inputs all info
                lagym.inputInfo(ref strength, ref health, ref time, ref cash,ref intel, ref gymMem, ref gymJob);
                //make character go inside ahah
                player.Visible = false;
                //show the form
                lagym.ShowDialog();
                //output all info
                lagym.outputInfo(ref strength, ref health, ref time, ref cash, ref gymMem, ref gymJob);
                //update info
                update();
                //player hops out
                player.Visible = true;
                //exit the gym
                exit("gym");

            }
            //hosp enter
            if (player.Bounds.IntersectsWith(picHosp.Bounds)) { 
                //new hosp class
                Hospital hospital = new Hospital();

                //inputs all info
                hospital.inputInfo(ref health, ref time, ref cash, ref intel, ref hosJob);
                //player goes invisible
                player.Visible = false;
                //show th form
                hospital.ShowDialog();
                //output all info
                hospital.outputInfo(ref health, ref time, ref cash, ref hosJob);
                //update info
                update();
                //player hops out
                player.Visible = true;
                //exit the gym
                exit("hos");
            }
            //u of t enter
            if (player.Bounds.IntersectsWith(picUot.Bounds)) {
                //new u of t class
                University uni = new University();
                //input all info
                uni.inputInfo(ref time, ref cash, ref intel, ref uniJob);
                //hide player
                player.Visible = false;
                //show uni form
                uni.ShowDialog();
                //output info
                uni.outputInfo(ref time, ref cash, ref intel, ref uniJob);
                //show player
                player.Visible = true;
                //update labels
                update();
                //exit the university
                exit("uot");
            }
            //bank enter
            if (player.Bounds.IntersectsWith(picBank.Bounds)) {
                //new bank class
                Bank bank = new Bank();
                //input info
                bank.inputInfo(ref cash, ref bankcash,ref intel, ref bnkJob, ref time);
                //hide player
                player.Visible = false;
                //show bank form
                bank.ShowDialog();
                //output info
                bank.outputInfo(ref cash, ref bankcash, ref bnkJob, ref time);
                //hide player
                player.Visible = true;
                //update all labels
                update();
                //exit spawn
                exit("bank");
            }
            //pizza pizza enter
            if (player.Bounds.IntersectsWith(picPiz.Bounds)) {
                //shows error
                MessageBox.Show("Pizza pizza is under constructions!", "Sorry");
                //exits out of pizza
                exit("pizza");
            }
            //policia enter
            if (player.Bounds.IntersectsWith(picPol.Bounds)) { 
                //new police class
                PoliceStation police = new PoliceStation();
                 //hide player
                player.Visible = false;
                //input info
                police.inputInfo(ref strength,ref time,ref cash, ref intel, ref polJob);
                //show screen
                police.ShowDialog();
                //show player
                player.Visible = true;
                //output info
                police.outputInfo(ref strength, ref time, ref cash, ref intel, ref polJob);
                //update all label
                update();
                //exit out
                exit("police");
            }
            //google enter
            if (player.Bounds.IntersectsWith(picGgl.Bounds)) {
                //new google class
                Google google = new Google();
                //hide player
                player.Visible = false;
                //input info
                google.inputInfo(ref cash, ref intel,ref time, ref gooJob);
                //show screen
                google.ShowDialog();
                //show player
                player.Visible = true;
                //output info
                google.outputInfo(ref cash, ref intel, ref time, ref gooJob);
                //update all erytin
                update();
                //exit at google entrance
                exit("google");
            }
            //enter the bay
            if (player.Bounds.IntersectsWith(picBay.Bounds)) {
                //new bay class
                TheBay bay = new TheBay();
                //hide player
                player.Visible = false;
                //input iinfo
                bay.inputInfo(ref cash, ref bayOwn);
                //show screen
                bay.ShowDialog();
                //show player
                player.Visible = true;
                //output erything
                bay.outputInfo(ref cash, ref bayOwn);
                //update erything
                update();
                //exit out the bay
                exit("bay");
            }
            
        }
        public void stopmove() { 
            //turns all movement keys off
            goleft = false;
            goup = false;
            goright = false;
            godown = false;
        }
        //sets all points for 
        public void exit(string spot){
            //exit locations
            Point timsSpawn = new Point();
            Point homeSpawn = new Point();
            Point gymSpawn = new Point();
            Point hosSpawn = new Point();
            Point uotSpawn = new Point();
            Point bnkSpawn = new Point();
            Point pzaSpawn = new Point();
            Point polSpawn = new Point();
            Point gglSpawn = new Point();
            Point baySpawn = new Point();

            //these are the backgrounds location outside the entrance
            gymSpawn.X = -973;
            gymSpawn.Y = 196;
            homeSpawn.X = -305;
            homeSpawn.Y = -722;
            timsSpawn.X = -928;
            timsSpawn.Y = -234;
            hosSpawn.X = -701;
            hosSpawn.Y = -216;
            uotSpawn.X = 147;
            uotSpawn.Y = -435;
            bnkSpawn.X = -695;
            bnkSpawn.Y = 153;
            pzaSpawn.X = -962;
            pzaSpawn.Y = -522;
            polSpawn.X = -703;
            polSpawn.Y = 534;
            gglSpawn.X = 301;
            gglSpawn.Y = -698;
            baySpawn.X = -198;
            baySpawn.Y = 111;

            //switch case that decides which exit to go to
            switch (spot)
            {
                case "tims":
                    spawn(timsSpawn);
                    break;
                case "home":
                    spawn(homeSpawn);
                    break;
                case "gym":
                    spawn(gymSpawn);
                    break;
                case "hos":
                    spawn(hosSpawn);
                    break;
                case "uot":
                    spawn(uotSpawn);
                    break;
                case "bank":
                    spawn(bnkSpawn);
                    break;
                case "pizza":
                    spawn(pzaSpawn);
                    break;
                case "police":
                    spawn(polSpawn);
                    break;
                case "google":
                    spawn(gglSpawn);
                    break;
                case "bay":
                    spawn(baySpawn);
                    break;
            }
        }

        //this method spawns the player at the entrance of the chosen building
        public void spawn(Point spawnLocation) {
            //set the bg location to the spawn location because thats where its derived from
            bg.Location = spawnLocation;
            //create all thenew points
            Point timsMove = new Point();
            Point homeMove = new Point();
            Point gymMove = new Point();
            Point pizMove = new Point();
            Point pollMove = new Point();
            Point polMove = new Point();
            Point bayMove = new Point();
            Point bankMove = new Point();
            Point hosMove = new Point();
            Point ttcMove = new Point();
            Point uniMove = new Point();
            Point gglMove = new Point();

            //moves all buildings according to the difference between them and the map
            timsMove.X = spawnLocation.X + 1551;
            timsMove.Y = spawnLocation.Y + 509;

            homeMove.X = spawnLocation.X + 443;
            homeMove.Y = spawnLocation.Y + 1121;
            
            gymMove.X = spawnLocation.X + 1563;
            gymMove.Y = spawnLocation.Y + 17;

            pizMove.X = spawnLocation.X + 1554;
            pizMove.Y = spawnLocation.Y + 807;

            pollMove.X = spawnLocation.X + 873;
            pollMove.Y = spawnLocation.Y + -498;

            bayMove.X = spawnLocation.X + 44;
            bayMove.Y = spawnLocation.Y + 83;

            bankMove.X = spawnLocation.X + 917;
            bankMove.Y = spawnLocation.Y + 26;

            ttcMove.X = spawnLocation.X + 1584;
            ttcMove.Y = spawnLocation.Y + 1211;

            hosMove.X = spawnLocation.X + 914;
            hosMove.Y = spawnLocation.Y + 401;

            uniMove.X = spawnLocation.X + 52;
            uniMove.Y = spawnLocation.Y + 494;

            gglMove.X = spawnLocation.X + 52;
            gglMove.Y = spawnLocation.Y + 1118;

            polMove.X = spawnLocation.X + 873 +38;
            polMove.Y = spawnLocation.Y + -498 + 156;

            //sets new locations for all buildings
            picTims.Location = timsMove;
            picHome.Location = homeMove;
            picGym.Location = gymMove;
            picPiz.Location = pizMove;
            picPoll.Location = pollMove;
            picBay.Location = bayMove;
            picBank.Location = bankMove;
            picTtc.Location = ttcMove;
            picHosp.Location = hosMove;
            picUot.Location = uniMove;
            picGgl.Location = gglMove;
            picPol.Location = polMove;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //update all info
            update();
            //make the info panel visible
            panInfo.Visible = true;
        }

        public void update() {
            //updates all label
            if (health > 100) health = 100; // prevents any errors, keeping it in the maximum
            healthBar.Value = health;
            lblDay.Text = "Day " + Convert.ToString(day);
            lblName.Text = "Name : " + name;
            lblCash.Text = "Cash : $" + Convert.ToString(cash);
            lblDollaz.Text = Convert.ToString(cash);
            lblTime.Text = Convert.ToString(time * 3) + ":00";
            lblStr.Text = "Strength : " + Convert.ToString(strength);
            lblIntel.Text = "Intelligence : " + Convert.ToString(intel);
            lblCharm.Text = "Charm : " + Convert.ToString(charm);
        }

        private void btnCloseInfoPan_Click(object sender, EventArgs e)
        {
            //hide the pannel when the close buton is clicked on the panel
            panInfo.Visible = false;
        }
        
        private void t_Tick(object sender, EventArgs e)
        {
        }
        
    }

}