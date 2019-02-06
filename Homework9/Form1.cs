using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int oppscore = 0, myscore = 0;
            LblOppScoreChange.Text = oppscore.ToString();
            LblPlayerScoreChange.Text = myscore.ToString();
        }
        public string OppChoice;
        public string MyChoice;
        public int OppScore;
        public int PlayerScore;
        private int counterup = 0, counterdown = 0;

        private void PanelClickPalossand_Click(object sender, EventArgs e)
        {
            PicBoxPlayerPokemonChoice.Image = Homework9.Properties.Resources.Palossand;            
            PicBoxPlayerPokemonChoice.Size = new Size(250, 214);
            PicBoxPlayerPokemonChoice.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PicBoxPlayerPokemonChoice.Location = new Point(250, 300);
            PicBoxOpponentPokemon.Image = OpponentChoice();
            PicBoxGO.Visible = false;
            MyChoice = "Palossand";
            string winner = Winner();
            LblOppScoreChange.Text = OppScore.ToString();
            LblPlayerScoreChange.Text = PlayerScore.ToString();
            if (winner == "tie")
            {
                LblTie.Visible = true;
                PicBoxPlayerSucOrFail.Image = null;
                PicBoxOpponentSucOrFail.Image = null;
            }
            if (winner == "player")
            {
                LblTie.Visible = false;
                PicBoxPlayerSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextSuccess;
                PicBoxOpponentSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextFailure;
                PlayerScore++;
            }
            if (winner == "opponent")
            {                
                LblTie.Visible = false;
                PicBoxOpponentSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextSuccess;
                PicBoxPlayerSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextFailure;
                OppScore++;
            }
            LblOppScoreChange.Text = OppScore.ToString();
            LblPlayerScoreChange.Text = PlayerScore.ToString();
            counterup = 0;
            counterdown = 0;
            TimerUp.Enabled = false;
            TimerDown.Enabled = false;
            Jump();
        }

        public void PanelCkickKyurem_Click(object sender, EventArgs e)
        {
            PicBoxPlayerPokemonChoice.Image = Homework9.Properties.Resources.Kyurem_BlackReversed;
            PicBoxPlayerPokemonChoice.Size = new Size(400, 450);            
            PicBoxPlayerPokemonChoice.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PicBoxPlayerPokemonChoice.Location = new Point(100, 75);
            PicBoxOpponentPokemon.Image = OpponentChoice();
            PicBoxGO.Visible = false;
            MyChoice = "Kyurem";
            string winner = Winner();
            LblOppScoreChange.Text = OppScore.ToString();
            LblPlayerScoreChange.Text = PlayerScore.ToString();
           
            if (winner == "tie")
            {
                LblTie.Visible = true;
                PicBoxPlayerSucOrFail.Image = null;
                PicBoxOpponentSucOrFail.Image = null;
            }
            if (winner == "player")
            {
                LblTie.Visible = false;
                PicBoxPlayerSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextSuccess;
                PicBoxOpponentSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextFailure;
                PlayerScore++;
                                                                      }
            if (winner == "opponent")
            {
                LblTie.Visible = false;
                PicBoxOpponentSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextSuccess;
                PicBoxPlayerSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextFailure;
                OppScore++;
            }
            LblOppScoreChange.Text = OppScore.ToString();
            LblPlayerScoreChange.Text = PlayerScore.ToString();
            counterup = 0;
            counterdown = 0;
            TimerUp.Enabled = false;
            TimerDown.Enabled = false;
            Jump();
        }


        private void PanelClickKlefki_Click(object sender, EventArgs e)
        {
            PicBoxPlayerPokemonChoice.Image = Homework9.Properties.Resources.Klefki;
            PicBoxPlayerPokemonChoice.Size = new Size(180, 125);
            PicBoxPlayerPokemonChoice.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PicBoxPlayerPokemonChoice.Location = new Point(250, 300);
            PicBoxOpponentPokemon.Image = OpponentChoice();
            PicBoxGO.Visible = false;
            MyChoice = "Klefki";
            string winner = Winner();
            LblOppScoreChange.Text = OppScore.ToString();
            LblPlayerScoreChange.Text = PlayerScore.ToString();
            if (winner == "tie")
            {
                LblTie.Visible = true;
                PicBoxPlayerSucOrFail.Image = null;
                PicBoxOpponentSucOrFail.Image = null;
            }
            if (winner == "player")
            {
                LblTie.Visible = false;
                PicBoxPlayerSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextSuccess;
                PicBoxOpponentSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextFailure;
                PlayerScore = PlayerScore + 1;
            }
            if (winner == "opponent")
            {
                LblTie.Visible = false;
                PicBoxOpponentSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextSuccess;
                PicBoxPlayerSucOrFail.Image = Homework9.Properties.Resources.SmashBrosTextFailure;
                OppScore = OppScore + 1;
            }
            LblOppScoreChange.Text = OppScore.ToString();
            LblPlayerScoreChange.Text = PlayerScore.ToString();
            counterup = 0;
            counterdown = 0;
            TimerUp.Enabled = false;
            TimerDown.Enabled = false;
            Jump();
        }
      

        public Bitmap OpponentChoice()
        {
            Bitmap bit = Homework9.Properties.Resources.BackgroundFairy;

            Random rand = new Random();
            int answer = rand.Next(1, 4);
            if (answer == 1)
            {                
                bit = Homework9.Properties.Resources.Klefki;
                PicBoxOpponentPokemon.Size = new Size(180, 125);
                PicBoxOpponentPokemon.Location = new Point(600, 300);
                OppChoice = "Klefki";
            }
            if (answer == 2)
            {                
                bit = Homework9.Properties.Resources.Kyurem_BlackReversed;
                PicBoxOpponentPokemon.Size = new Size(400, 450);
                PicBoxOpponentPokemon.Location = new Point(600, 75);
                OppChoice = "Kyurem";
            }
            if (answer == 3)
            {
                bit = Homework9.Properties.Resources.Palossand;
               PicBoxOpponentPokemon.Size = new Size(250, 214);
                PicBoxOpponentPokemon.Location = new Point(600, 300);
                OppChoice = "Palossand";
            }
            return bit;
        }
        public string Winner()
        {
            string winner = "error";
            if (OppChoice == MyChoice)
            {
                winner = "tie";
            }
            if (MyChoice == "Klefki" && OppChoice == "Kyurem")
            {
                winner = "player";
            }
            if (MyChoice == "Klefki" && OppChoice == "Palossand")
            {
                winner = "opponent";
            }
            if (MyChoice == "Kyurem" && OppChoice == "Palossand")
            {
                winner = "player";
            }
            if (MyChoice == "Kyurem" && OppChoice == "Klefki")
            {
                winner = "opponent";
            }
            if (MyChoice == "Palossand" && OppChoice == "Klefki")
            {
                winner = "player";
            }
            if (MyChoice == "Palossand" && OppChoice == "Kyurem")
            {
                winner = "opponent";
            }
            return winner;
        }

        public Bitmap OpponentSprite()
        {
            Bitmap bit = Homework9.Properties.Resources.BackgroundFairy;
            Random rand = new Random();
            int random = rand.Next(0, 20);
           
            List<System.Drawing.Bitmap> EnemySprites = new List<System.Drawing.Bitmap>();
            EnemySprites.Insert(0, Homework9.Properties.Resources.SpriteArcheologist);
            EnemySprites.Insert(1, Homework9.Properties.Resources.SpriteBoySwimmer);
            EnemySprites.Insert(2, Homework9.Properties.Resources.SpriteBugCatcher);
            EnemySprites.Insert(3, Homework9.Properties.Resources.SpriteClown);
            EnemySprites.Insert(4, Homework9.Properties.Resources.SpriteDragonTamer);
            EnemySprites.Insert(5, Homework9.Properties.Resources.SpriteFAceTrainer);
            EnemySprites.Insert(6, Homework9.Properties.Resources.SpriteFisherman);
            EnemySprites.Insert(7, Homework9.Properties.Resources.SpriteGangster);
            EnemySprites.Insert(8, Homework9.Properties.Resources.SpriteHiker);
            EnemySprites.Insert(9, Homework9.Properties.Resources.SpriteLady);            
            EnemySprites.Insert(10, Homework9.Properties.Resources.SpriteLadyBeauty);
            EnemySprites.Insert(11, Homework9.Properties.Resources.SpriteMAceTrainer);
            EnemySprites.Insert(12, Homework9.Properties.Resources.SpriteNinjaBoy);
            EnemySprites.Insert(13, Homework9.Properties.Resources.SpriteOldLady);
            EnemySprites.Insert(14, Homework9.Properties.Resources.SpriteRichBoy);
            EnemySprites.Insert(15, Homework9.Properties.Resources.SpriteSailor);
            EnemySprites.Insert(16, Homework9.Properties.Resources.SpriteSwimmerMale);
            EnemySprites.Insert(17, Homework9.Properties.Resources.SpriteTeacher);
            EnemySprites.Insert(18, Homework9.Properties.Resources.SpriteVeteran);
            EnemySprites.Insert(19, Homework9.Properties.Resources.SpriteWaitress);           
            bit = EnemySprites[random];

            List<string> SpriteNames = new List<string>();
            SpriteNames.Insert(0, "Archeologist");
            SpriteNames.Insert(1, "Tuber");
            SpriteNames.Insert(2, "Bug Catcher");
            SpriteNames.Insert(3, "Clown");
            SpriteNames.Insert(4, "Dragon Tamer");
            SpriteNames.Insert(5, "Ace Trainer");
            SpriteNames.Insert(6, "Fisherman");
            SpriteNames.Insert(7, "Gangster");
            SpriteNames.Insert(8, "Hiker");
            SpriteNames.Insert(9, "Lady");
            SpriteNames.Insert(10, "Beauty");
            SpriteNames.Insert(11, "Ace Trainer");
            SpriteNames.Insert(12, "Ninja");
            SpriteNames.Insert(13, "Elderly Lady");
            SpriteNames.Insert(14, "Rich Boy");
            SpriteNames.Insert(15, "Sailor");
            SpriteNames.Insert(16, "Swimmer");
            SpriteNames.Insert(17, "Teacher");
            SpriteNames.Insert(18, "Veteran");
            SpriteNames.Insert(19, "Waitress");
            string oppname = SpriteNames[random];
            LblOppScore.Text = $"{oppname} Score ";
            return bit;
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            PicBoxPlayerPokemonChoice.Image = null;
            PicBoxOpponentPokemon.Image = null;
            PicBoxOpponent.Image = null;
            PicBoxPlayer.Image = null;           
            PanelToHideLeft.Visible = true;
            PanelToHideMiddle.Visible = true;
            PanelToHideRight.Visible = true;
            BtnToHide1.Visible = true;
            BtnToHide2.Visible = true;
            BtntoHide3.Visible = true;
            LbllToHide1.Visible = true;
            LblToHide2.Visible = true;
            LblTie.Visible = false;
            PicBoxPlayerSucOrFail.Image = null;
            PicBoxOpponentSucOrFail.Image = null;
            OppScore = 0;
            PlayerScore = 0;
            LblPlayerScoreChange.Text = OppScore.ToString();
            LblOppScoreChange.Text = OppScore.ToString();
            PicBoxGO.Visible = true;
            TimerUp.Enabled = false;
            TimerDown.Enabled = false;
        }

        private void BtnHint_Click(object sender, EventArgs e)
        {
            LblHintDrag.Visible = !LblHintDrag.Visible;
            LblHintFairy.Visible = !LblHintFairy.Visible;
            LblHintGhost.Visible = !LblHintGhost.Visible;
            LblHintGround.Visible = !LblHintGround.Visible;
            LblHintIce.Visible = !LblHintIce.Visible;
            LblHintSteel.Visible = !LblHintSteel.Visible;
            BtnCloseHint.Visible = !BtnCloseHint.Visible;
            PicBoxCircleArrows.Visible = !PicBoxCircleArrows.Visible;
            PicBoxHintDrag.Visible = !PicBoxHintDrag.Visible;
            PicBoxHintFairy.Visible = !PicBoxHintFairy.Visible;
            PicBoxHintGhost.Visible = !PicBoxHintGhost.Visible;
            PicBoxHintGround.Visible = !PicBoxHintGround.Visible;
            PicBoxHintIce.Visible = !PicBoxHintIce.Visible;
            PicBoxHintKlefki.Visible = !PicBoxHintKlefki.Visible;
            PicBoxHintKyurem.Visible = !PicBoxHintKyurem.Visible;
            PicBoxHintPallossand.Visible = !PicBoxHintPallossand.Visible;
            PicBoxHintSteel.Visible = !PicBoxHintSteel.Visible;
            PanelTips.Visible = !PanelTips.Visible;
            PicBoxGO.Visible = false;
        }

        private void BtnCloseHint_Click(object sender, EventArgs e)
        {
            LblHintDrag.Visible = false;
            LblHintFairy.Visible = false;
            LblHintGhost.Visible = false;
            LblHintGround.Visible = false;
            LblHintIce.Visible = false;
            LblHintSteel.Visible = false;
            BtnCloseHint.Visible = false;
            PicBoxCircleArrows.Visible = false;
            PicBoxHintFairy.Visible = false;
            PicBoxHintGhost.Visible = false;
            PicBoxHintGround.Visible = false;
            PicBoxHintIce.Visible = false;
            PicBoxHintDrag.Visible = false;
            PicBoxHintKlefki.Visible = false;
            PicBoxHintKyurem.Visible = false;
            PicBoxHintPallossand.Visible = false;
            PicBoxHintSteel.Visible = false;
            PanelTips.Visible = false;
        }

        private void BtnToHide2_Click_1(object sender, EventArgs e)
        {
            PicBoxPlayer.Image = Homework9.Properties.Resources.PlayerLucasBack;
            PanelToHideLeft.Visible = false;
            PanelToHideMiddle.Visible = false;
            PanelToHideRight.Visible = false;
            BtnToHide1.Visible = false;
            BtnToHide2.Visible = false;
            BtntoHide3.Visible = false;
            LbllToHide1.Visible = false;
            LblToHide2.Visible = false;
            PicBoxOpponent.Image = OpponentSprite();
        }

        private void BtnToHide1_Click_1(object sender, EventArgs e)
        {
            PicBoxPlayer.Image = Homework9.Properties.Resources.PlayerDawnBack;
            PanelToHideLeft.Visible = false;
            PanelToHideMiddle.Visible = false;
            PanelToHideRight.Visible = false;
            BtnToHide1.Visible = false;
            BtnToHide2.Visible = false;
            BtntoHide3.Visible = false;
            LbllToHide1.Visible = false;
            LblToHide2.Visible = false;
            PicBoxOpponent.Image = OpponentSprite();
        }

        private void BtntoHide3_Click_1(object sender, EventArgs e)
        {
            PicBoxPlayer.Image = Homework9.Properties.Resources.PlayerBarryBack;
            PanelToHideLeft.Visible = false;
            PanelToHideMiddle.Visible = false;
            PanelToHideRight.Visible = false;
            BtnToHide1.Visible = false;
            BtnToHide2.Visible = false;
            BtntoHide3.Visible = false;
            LbllToHide1.Visible = false;
            LblToHide2.Visible = false;
            PicBoxOpponent.Image = OpponentSprite();
        }
 
        private void Jump() // just initiates the timer and runs some if statements to determine interval speed for the timer.
        {
            string winner = Winner();
            TimerUp.Enabled = true;
            if (winner == "player")
            {
                if (MyChoice == "Klefki")
                {
                    TimerUp.Interval = 100;
                    TimerDown.Interval = 100;
                    int test = TimerDown.Interval;
                }
                if (MyChoice == "Palossand")
                {
                    TimerUp.Interval = 150;
                    TimerDown.Interval = 150;
                }
                if (MyChoice == "Kyurem")
                {
                    TimerUp.Interval = 10;
                    TimerDown.Interval = 10;
                }
            }
            if (winner == "opponent")
            {
                if (OppChoice == "Klefki")
                {
                    TimerUp.Interval = 100;
                    TimerDown.Interval = 100;
                }
                if (OppChoice == "Palossand")
                {
                    TimerUp.Interval = 150;
                    TimerDown.Interval = 150;
                }
                if (OppChoice == "Kyurem")
                {
                    TimerUp.Interval = 10;
                    TimerDown.Interval = 10;
                }
            }
        }
        //Citation for the Timer moving pictureboxes:
        //https://www.youtube.com/watch?v=Q4zXb4LSi50&t=96s
       
        private void TimerUp_Tick(object sender, EventArgs e)
        {

            counterup++;
            if (counterup == 6)
            {
                TimerUp.Stop();               
                TimerDown.Enabled = true;
                counterup = 0;
            }
            string winner = Winner();
            if (winner == "player")
            {
                PicBoxPlayerPokemonChoice.Location = new Point(PicBoxPlayerPokemonChoice.Location.X, PicBoxPlayerPokemonChoice.Location.Y - 5);
            }
            if (winner == "opponent")
            {
                PicBoxOpponentPokemon.Location = new Point(PicBoxOpponentPokemon.Location.X, PicBoxOpponentPokemon.Location.Y - 5);
            }
        }
        private void TimerDown_Tick(object sender, EventArgs e)
        {
            counterdown++;
            if (counterdown == 6)
            {
                TimerDown.Stop();                
                TimerUp.Enabled = true;
                counterdown = 0;
            }
            string winner = Winner();
            if (winner == "player")
            {
                PicBoxPlayerPokemonChoice.Location = new Point(PicBoxPlayerPokemonChoice.Location.X, PicBoxPlayerPokemonChoice.Location.Y + 5);
            }
            if (winner == "opponent")
            {
                PicBoxOpponentPokemon.Location = new Point(PicBoxOpponentPokemon.Location.X, PicBoxOpponentPokemon.Location.Y + 5);
            }
           
        }

        //----------------------------------------------------------------------- 
        // The methods below do nothing, but cannot be deleted without creating an error. Caused by double clicking in the gui.

        private void LblTie_Click(object sender, EventArgs e)
        {

        }

        private void LblOpponentScore_Click(object sender, EventArgs e)
        {

        }

        private void PanelToHideMiddle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
