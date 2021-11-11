using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Project_Breakout
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {
            InitializeComponent();
            questionLabel.Text = "SELECT CHARACTER";
            buttonLabel1.Text = "Ethan";
            buttonLabel2.Text = "Hector";
           
        }

       

        private void optionButton1_Click(object sender, EventArgs e)
        {
                  if (page == 1) {page = 2;}
            else if (page == 2)  { page = 4;}
            else if (page == 4)  { page = 1;}
            else if (page == 6)  { page = 10;}
            else if (page == 8)  { page = 1;}
            else if (page == 10) { page = 14;}
            else if (page == 12) { page = 1;}
            else if (page == 14) { page = 18;}
            else if (page == 16) { page = 1;}
            else if (page == 18) { page = 20;}
            else if (page == 20) { page = 1;}
            else if (page == 22) { page = 1;}

            else if (page == 3)  { page = 7;}
            else if (page == 5)  { page = 1;}
            else if (page == 7)  { page = 11;}
            else if (page == 9)  { page = 1;}
            else if (page == 11) { page = 13;}
            else if (page == 13) { page = 1;}
            else if (page == 15) { page = 17;}
            else if (page == 17) { page = 1;}
            else if (page == 19) { page = 1;}
            else if (page == 99) { page = 101;}


            DisplayPage();
        }

        private void optionBotton2_Click(object sender, EventArgs e)
        {
                 if (page == 1)  { page = 3;}
            else if (page == 2)  { page = 6;}
            else if (page == 4)  { page = 99;}
            else if (page == 8)  { page = 99;}
            else if (page == 6)  { page = 8;}
            else if (page == 12) { page = 99;}
            else if (page == 10) { page = 12;}
            else if (page == 14) { page = 16;}
            else if (page == 16) { page = 99;}
            else if (page == 18) { page = 22;}
            else if (page == 20) { page = 99;}
            else if (page == 22) { page = 99;}

            else if (page == 3)  { page = 5;}
            else if (page == 5)  { page = 99;}
            else if (page == 7)  { page = 9;}
            else if (page == 9)  { page = 99;}
            else if (page == 11) { page = 15;}
            else if (page == 13) { page = 99;}
            else if (page == 15) { page = 19;}
            else if (page == 17) { page = 99;}
            else if (page == 19) { page = 99;}
            else if (page == 99) { page = 101;}

            DisplayPage();
        }
        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    questionLabel.Text = "Select Character";
                    buttonLabel1.Text = "Ethan";
                    buttonLabel2.Text = "Hector";

                    SoundPlayer openingPlayer = new SoundPlayer(Properties.Resources._583563__lost_dream__wandering);
                    openingPlayer.Play();

                    photoImage2.Image = (Properties.Resources.Ethan);
                    photoImage3.Image = (Properties.Resources.Ethan);


                    break;
                case 2:
                    questionLabel.Text = " You  are in room conducting an experiment in the facility and you heard the a strange  sound. Do you want to go out? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    SoundPlayer brookPlayer = new SoundPlayer(Properties.Resources._583563__lost_dream__wandering);
                    brookPlayer.Play();

                    photoImage2.Image = (Properties.Resources.Ethan);
                    
                    break;
                case 4:
                    questionLabel.Text = " You tried to  check were the sound came from, but along the way an explosion occurred and you got caught with it that cause you your life . Play again? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 6:
                    questionLabel.Text = " You stayed in your room for a while, but suddenly you heard an explosion outside of your room. Would you like to check or not ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 8:
                    questionLabel.Text = " You were afraid to check and stayed in your room for a while, then the next thing you know that the ceiling started to crumble that crushed you to death. Play again? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 10:
                    questionLabel.Text = " You went out of your room and you noticed people running and you heard a strange sound echoing from the upper floor. Do you want to check ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 12:
                    questionLabel.Text = " You decided to run for your life but you got crushed by a huge concrete on your way out and die. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 14:
                    questionLabel.Text = " You check the upper floor and heard another explosion along the way. Do you wish to check ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 16:
                    questionLabel.Text = " You got scared and left, but as soon as you were running down the stairs, the ceiling above you started to fall down that crushed you to death. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 18:
                    questionLabel.Text = " You decided to check were the explosion occurred, then you saw a bomb attached to the Nitrogen tanks. Do you wish to disable to bomb ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 20:
                    questionLabel.Text = "You tried to disable the bomb but you failed and the bomb explode near you that shattered your body to pieces. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 22:
                    questionLabel.Text = "You took the bomb instead and threw it in the nearest window  of the room and manage to save half the facility from getting demolished by the explosion. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 99:
                    questionLabel.Text = "Thanks for Playing.";
                    buttonLabel1.Text = "Exit";
                    buttonLabel2.Visible = false;                  
                    break;
                case 3:
                    questionLabel.Text = "You are now tasked to enter the facility with a bomb in your bag, but you were approached by the guard. Do you wish you knock him down ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage3.Image = (Properties.Resources.Hector_image);

                    break;
                case 5:
                    questionLabel.Text = "You tried to act like you were lost, but the guard got suspicious that made you ditch the mission. Play again? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage3.Image = (Properties.Resources.Hector_image);

                    break;
                case 7:
                    questionLabel.Text = "You successfully knock him down and sneaked in through the windows of the facility. Do you wish to continue?  ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage3.Image = (Properties.Resources.Hector_image);

                    break;
                case 9:
                    questionLabel.Text = "  You  ditch the mission and went home with full of regrets. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage3.Image = (Properties.Resources.Hector_image);

                    break;
                case 11:
                    questionLabel.Text = "You are now inside the facility and headed towards the room that contains the Nitrogen tanks, but the doors for that room was locked. Do you wish to break it ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage3.Image = (Properties.Resources.Hector_image);

                    break;
                case 13:
                    questionLabel.Text = "You tried to break  the door, but it was no use and gave up after several tries. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage3.Image = (Properties.Resources.Hector_image);

                    break;
                case 15:
                    questionLabel.Text = "You tried to find another way inside the room and you noticed a vent on the upper side of the door. Would you like to go in the vent?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage3.Image = (Properties.Resources.Hector_image);

                    break;
                case 17:
                    questionLabel.Text = "You tried to go in the vent but got stuck instead and failed. Play again? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage3.Image = (Properties.Resources.Hector_image);

                    break;
                case 19:
                    questionLabel.Text = "You used explosive to create an entrance between vent and you successfully placed the bombs near the nitrogen tanks And made your escape by jumping outside the window of the facility. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";

                    photoImage3.Image = (Properties.Resources.Hector_image);

                    break;
                case 101:
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}
