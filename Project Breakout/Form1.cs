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
            buttonLabel3.Text = "Try";
            DisplayPage();
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
            else if (page == 21) { page = 1; }

            if (page == 15)
            {
                Random randGen = new Random();
                int randValue = randGen.Next(1, 101);

                if (randValue < 70)
                {
                    page = 21;
                }
                else
                {
                    page = 17;
                }
                }                     
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
            else if (page == 21) { page = 99; }
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

        private void buttonLabel3_Click(object sender, EventArgs e)
        {
             if (page == 6) { page = 23; }      
            else if (page == 23) { page = 99; }
            else if (page == 14) { page = 25; }
            else if (page == 25) { page = 99; }
            else if (page == 11) { page = 27; }
            else if (page == 27) { page = 99; }
           

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
                    buttonLabel3.Visible = false;

                    SoundPlayer openingPlayer = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    openingPlayer.Play();

                    photoImage.Image = (Properties.Resources.ProjectBreakout_Logo);
                    //photoImage2.Image = (Properties.Resources.Ethan);
                    //photoImage3.Image = (Properties.Resources.Hector);
                    photoImage2.Image = null;
                    photoImage3.Image = null;

                    Refresh();
                   


                    break;
                case 2:
                    questionLabel.Text = " You  are in room conducting an experiment in the \nfacility and you heard the a strange  sound. Do you want to go out? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer Steps = new SoundPlayer(Properties.Resources.footsteps_Concrete);
                    Steps.Play();

                    photoImage.Image = (Properties.Resources.Doorway);
                    photoImage2.Image = Properties.Resources.Ethan;
                    
                    break;
                case 4:
                    questionLabel.Text = " You tried to  check were the sound came from, but along the way an explosion \noccurred and you got caught with it that cause you your life . Play again? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer Explode_1 = new SoundPlayer(Properties.Resources.Explosion);
                    Explode_1.Play();

                    photoImage.Image = (Properties.Resources.BombExplode);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 6:
                    questionLabel.Text = " You stayed in your room for a while, but suddenly you heard an \nexplosion outside of your room. Would you like to check or not ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer Explode = new SoundPlayer(Properties.Resources.Explosion);
                   Explode.Play();

                    photoImage.Image = (Properties.Resources.Doorway);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 8:
                    questionLabel.Text = " You were afraid to check and stayed in your room for a while, then the next thing you know that\n the ceiling started to crumble that crushed you to death. Play again? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer SoundPlayer_6 = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    SoundPlayer_6.Play();

                    photoImage.Image = (Properties.Resources.Doorway);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 10:
                    questionLabel.Text = " You went out of your room and you noticed people running and you heard a strange sound \nechoing from the upper floor. Do you want to check ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer StrangeSound = new SoundPlayer(Properties.Resources.footsteps_Concrete);
                    StrangeSound.Play();

                    photoImage.Image = (Properties.Resources.Doorway);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 12:
                    questionLabel.Text = " You decided to run for your life but you got \ncrushed by a huge concrete on your way out and die. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer MaleScreaM = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    MaleScreaM.Play();
                    photoImage.Image= (Properties.Resources.you_died);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 14:
                    questionLabel.Text = " You check the upper floor and heard another explosion along the way. Do you wish to check ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer Kaboom_3 = new SoundPlayer(Properties.Resources.Explosion);
                    Kaboom_3.Play();

                    photoImage.Image = (Properties.Resources.straiway);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 16:
                    questionLabel.Text = " You got scared and left, but as soon as you were running down the stairs, the ceiling above \nyou started to fall down that crushed you to death. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer PLAYerdied = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    PLAYerdied.Play();

                    photoImage.Image = (Properties.Resources.straiway);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 18:
                    questionLabel.Text = " You decided to check were the explosion occurred, then you saw a bomb attached to the \nNitrogen tanks. Do you wish to disable to bomb ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer iNTRO = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    iNTRO.Play();

                    photoImage.Image = (Properties.Resources.Bomb);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 20:
                    questionLabel.Text = "You tried to disable the bomb but you failed and the bomb \nexplode near you that shattered your body to pieces. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer Kaboom_1 = new SoundPlayer(Properties.Resources.Explosion);
                    Kaboom_1.Play();

                    photoImage.Image = (Properties.Resources.BombExplode);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 22:
                    questionLabel.Text = "You took the bomb instead and threw it in the nearest window  of the room and manage \nto save half the facility from getting demolished by the explosion. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer Boom = new SoundPlayer(Properties.Resources.Explosion);
                    Boom.Play();

                    photoImage.Image = (Properties.Resources.BombExplode);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 99:
                    questionLabel.Text = "Thanks for Playing.";
                    buttonLabel1.Text = "Exit";
                    buttonLabel2.Visible = false;
                    buttonLabel3.Visible = false;

                    SoundPlayer Hooray = new SoundPlayer(Properties.Resources.Hooray);
                    Hooray.Play();

                    photoImage.Image = (Properties.Resources.ty_for_Playing);

                    break;
                case 3:
                    questionLabel.Text = "You are now tasked to enter the facility with a bomb in your bag, but you were \napproached by the guard. Do you wish you knock him down ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer SoundPlayer_4 = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    SoundPlayer_4.Play();

                    photoImage.Image = (Properties.Resources.guard_image);
                    photoImage3.Image = (Properties.Resources.Hector);

                    break;
                case 5:
                    questionLabel.Text = "You tried to act like you were lost, but the \nguard got suspicious that made you ditch the mission. Play again? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer SoundPlayer_3 = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    SoundPlayer_3.Play();

                    photoImage.Image = (Properties.Resources.guard_image);
                    photoImage3.Image = (Properties.Resources.Hector);

                    break;
                case 7:
                    questionLabel.Text = "You successfully knock him down and sneaked in \nthrough the windows of the facility. Do you wish to continue?  ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer SoundPlayer_5 = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    SoundPlayer_5.Play();

                    photoImage.Image = (Properties.Resources.Window);
                    photoImage3.Image = (Properties.Resources.Hector);

                    break;
                case 9:
                    questionLabel.Text = "  You  ditch the mission and went home with full of regrets. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer Missionfailed = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    Missionfailed.Play();

                    photoImage.Image = (Properties.Resources.walkaway);
                    photoImage3.Image = (Properties.Resources.Hector);

                    break;
                case 11:
                    questionLabel.Text = "You are now inside the facility and headed towards the room that contains the \nNitrogen tanks, but the doors for that room was locked. Do you wish to break it ? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer SoundPlayer_2 = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    SoundPlayer_2.Play(); 

                    photoImage.Image = (Properties.Resources.Nitrogen_tanks);
                    photoImage3.Image = (Properties.Resources.Hector);

                    break;
                case 13:
                    questionLabel.Text = "You tried to break  the door, but it was no use and gave up after several tries. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer TaskFailed_5 = new SoundPlayer(Properties.Resources.lost_dream_sound);                                 
                   TaskFailed_5.Play();

                    photoImage.Image = (Properties.Resources.metal_door);
                    photoImage3.Image = (Properties.Resources.Hector);

                    break;
                case 15:
                    questionLabel.Text = "You tried to find another way inside the room and you noticed a vent on the \nupper side of the door. Would you like to go in the vent?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                    SoundPlayer SoundPlayer = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    SoundPlayer.Play();

                    photoImage.Image = (Properties.Resources.Vent);
                    photoImage3.Image = (Properties.Resources.Hector);



                    break;
                case 17:
                    questionLabel.Text = "You tried to go in the vent but got stuck instead and failed. Play again? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                  
                    SoundPlayer TaskFailed = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    TaskFailed.Play();

                    photoImage.Image = (Properties.Resources.Vent);
                    photoImage3.Image = (Properties.Resources.Hector);

                    break;
                case 19:
                    questionLabel.Text = "You used explosive to create an entrance between vent and you successfully placed \nthe bombs near the nitrogen tanks And made your escape by jumping outside the window of the facility. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Visible = false;

                   SoundPlayer kaboom = new SoundPlayer(Properties.Resources.Explosion);
                    kaboom.Play();

                    photoImage3.Image = (Properties.Resources.Hector);

                    break;
                case 21:
                    questionLabel.Text = "You successfully fit yourself in and placed the bombs around \nthe tanks and made your escape through the window. Play again? ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                  
                    SoundPlayer TaskFailed_1 = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    TaskFailed_1.Play();

                    photoImage.Image = (Properties.Resources.Window);
                    photoImage3.Image = (Properties.Resources.Hector);

                    break;
                case 23:
                    questionLabel.Text = "You ignored what was happening outside and you continue to do your research, \nbut for a while the ceiling started to collapsed and crushed you to your death. Play again?  ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Text = "Try";
                    SoundPlayer TaskFailed_2 = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    TaskFailed_2.Play();

                    photoImage.Image = (Properties.Resources.Doorway);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;
                case 25:
                    questionLabel.Text = "You sprinted your way up the floor, but you tripped and fall over 10 \nsteps that broke your neck that cause you your death. Play again?";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";
                    buttonLabel3.Text = "Try";

                    SoundPlayer TaskFailed_3 = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    TaskFailed_3.Play();

                    photoImage.Image = (Properties.Resources.straiway);
                    photoImage2.Image = (Properties.Resources.Ethan);

                    break;

                case 27:
                    questionLabel.Text = "You tried to lockpick the door which took over 10 minutes of your \neffort and failed miserably and got caught after the multiple attempts. Play again?  ";
                    buttonLabel1.Text = "Yes";
                    buttonLabel2.Text = "No";//test
                    buttonLabel3.Text = "Try";

                    SoundPlayer TaskFailed_4 = new SoundPlayer(Properties.Resources.lost_dream_sound);
                    TaskFailed_4.Play();

                    photoImage.Image = (Properties.Resources.metal_door);
                    photoImage2.Image = (Properties.Resources.Hector);

                    break;
                case 101:
                    Thread.Sleep(2000);
                    Application.Exit();
                    
                    break;
                default:
                    break;
            }
        }

       
    }

}
