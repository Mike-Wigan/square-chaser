using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace square_chaser
{
    public partial class Form1 : Form
    {
        Random x = new Random();

        Rectangle player1 = new Rectangle(470, 290, 25, 25);
        Rectangle player2 = new Rectangle(520, 290, 25, 25);
        Rectangle square = new Rectangle(509, 500, 15, 15);
        Rectangle ball = new Rectangle(509, 100, 40, 40);
        Rectangle powerup = new Rectangle(300, 100, 15, 15);
        Rectangle border = new Rectangle(50, 50, 900, 500);

        SoundPlayer point = new SoundPlayer(Properties.Resources.pointsound);
        SoundPlayer powerupaudio = new SoundPlayer(Properties.Resources.powerupsound);

        int player1score = 0;
        int player2score = 0;
        int player1speed = 2;
        int player2speed = 2;
        int ballxspeed = 10;
        int ballyspeed = 10;
        int p1powerups = 0;
        int p2powerups = 0;

        bool wdown = false;
        bool adown = false;
        bool sdown = false;
        bool ddown = false;
        bool uparrowdown = false;
        bool downarrowdown = false;
        bool rightarrowdown = false;
        bool leftarrowdown = false;
        bool rdown = false;

        SolidBrush yellowbrush = new SolidBrush(Color.Yellow);
        SolidBrush greenbrush = new SolidBrush(Color.Green);
        SolidBrush redbrush = new SolidBrush(Color.Red);
        SolidBrush bluebrush = new SolidBrush(Color.Blue);
        SolidBrush brownbrush = new SolidBrush(Color.Brown);
        Pen whitepen = new Pen(Color.White);

        public Form1()
        {
            InitializeComponent();
            winlabel.Visible = false;
            outputlabel.Visible = false;
        }
        public void win()
        {
            winlabel.Visible = true;
            outputlabel.Visible = true;
            outputlabel.Text = "Press R to reset";
        }
        public void stop() 
        {
            win();
            ballxspeed = 0;
            ballyspeed = 0;
            player1speed = 0;
            player2speed = 0;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wdown = true;
                    break;
                case Keys.A:
                    adown = true;
                    break;
                case Keys.S:
                    sdown = true;
                    break;
                case Keys.D:
                    ddown = true;
                    break;
                case Keys.R:
                    rdown = true;
                    break;
                case Keys.Up:
                    uparrowdown = true;
                    break;
                case Keys.Down:
                    downarrowdown = true;
                    break;
                case Keys.Right:
                    rightarrowdown = true;
                    break;
                case Keys.Left:
                    leftarrowdown = true;
                    break;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wdown = false;
                    break;
                case Keys.A:
                    adown = false;
                    break;
                case Keys.S:
                    sdown = false;
                    break;
                case Keys.D:
                    ddown = false;
                    break;
                case Keys.R:
                    rdown = false;
                    break;
                case Keys.Up:
                    uparrowdown = false;
                    break;
                case Keys.Down:
                    downarrowdown = false;
                    break;
                case Keys.Right:
                    rightarrowdown = false;
                    break;
                case Keys.Left:
                    leftarrowdown = false;
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(whitepen, border);// border
            e.Graphics.FillRectangle(yellowbrush, square);//square
            e.Graphics.FillRectangle(redbrush, player1);//player 1
            e.Graphics.FillRectangle(bluebrush, player2);//player 2
            e.Graphics.FillEllipse(greenbrush, ball);//ball
            e.Graphics.FillRectangle(brownbrush, powerup);
        }

        private void GameTimer(object sender, EventArgs e)
        {
            ball.X -= ballxspeed;
            ball.Y -= ballyspeed;
            //reset
            if (rdown == true)
            {
                p1scorelabel.Text = $"{player1score}";
                p2scorelabel.Text = $"{player2score}";
                square.X = 50;
                square.Y = 500;
                player1.X = 470;
                player1.Y = 290;
                player2.X = 520;
                player2.Y = 290;
                player1score = 0;
                player2score = 0;
                winlabel.Visible = false;
                outputlabel.Visible = false;
                ballxspeed = 10;
                ballyspeed = 10;
                player1speed = 2;
                player2speed = 2;
                p1powerups = 0;
                p2powerups = 0;
            }
            //if (player1)
            //{
            //player1
            if (wdown == true && player1.Y > 50)
            {
                player1.Y -= player1speed;
            }
            if (sdown == true && player1.Y < 524)
            {
                player1.Y += player1speed;
            }
            if (adown == true && player1.X > 52)
            {
                player1.X -= player1speed;
            }
            if (ddown == true && player1.X < 924)
            {
                player1.X += player1speed;
            }
            //player 2
            if (uparrowdown == true && player2.Y > 50)
            {
                player2.Y -= player2speed;
            }
            if (downarrowdown == true && player2.Y < 524)
            {
                player2.Y += player2speed;
            }
            if (rightarrowdown == true && player2.X < 924)
            {
                player2.X += player2speed;
            }
            if (leftarrowdown == true && player2.X > 52)
            {
                player2.X -= player2speed;
            }
            //ball
            if (ball.Y < border.Y || ball.Y > border.Height)
            {
                ballxspeed += x.Next(-5, 5);
                ballyspeed *= -1;
            }
            if (ball.X > border.Width || ball.X < border.X)
            {
                ballyspeed += x.Next(-5, 5);
                ballxspeed *= -1;
            }
            if (ball.X <= 0 || ball.X >= 1000 || ball.Y >= 600 || ball.Y <= 0)
            {
                ball.X = x.Next(50, 900);
                ball.Y = x.Next(50, 500);
            }
            //intersectons
            if (player2.IntersectsWith(square))
            {
                point.Play();
                player2score++;
                square.X = x.Next(50, 900);
                square.Y = x.Next(50, 500);
                p2scorelabel.Text = $"{player2score}";
            }
            if (player1.IntersectsWith(square))
            {
                point.Play();
                player1score++;
                square.X = x.Next(50, 900);
                square.Y = x.Next(50, 500);
                p1scorelabel.Text = $"{player1score}";
            }
            if (player1.IntersectsWith(ball))
            {
                ball.X = x.Next(50, 900);
                ball.Y = x.Next(50, 500);
                player1score--;
                p1scorelabel.Text = $"{player1score}";
                if (p1powerups > 0)
                {
                    p1powerups--;
                    player1speed--;
                }
            }
            if (player2.IntersectsWith(ball))
            {
                ball.X = x.Next(50, 900);
                ball.Y = x.Next(50, 500);
                player2score--;
                p2scorelabel.Text = $"{player2score}";
                if (p2powerups > 0)
                {
                    p2powerups--;
                    player2speed--;
                }
            }
            //scoreing
            if (player1score == 5 || player2score <= -5)
            {
                winlabel.Text = "Red Wins";
                stop();
            }
            else if (player2score == 5 || player1score <= -5)
            {
                winlabel.Text = "Blue Wins";
                stop();
            }
            //powerup
            if (p1powerups < 3 && player1.IntersectsWith(powerup))
            {
                powerupaudio.Play();
                player1speed++;
                powerup.X = x.Next(50, 900);
                powerup.Y = x.Next(50, 500);
                p1powerups++;
            }
            if (p2powerups <= 3 && player2.IntersectsWith(powerup))
            {
                powerupaudio.Play();
                player2speed++;
                powerup.X = x.Next(50, 900);
                powerup.Y = x.Next(50, 500);
                p2powerups++;
            }
            if (player1.IntersectsWith(powerup) && p1powerups >= 3 || p2powerups >= 3 && player2.IntersectsWith(powerup))
            {
                powerupaudio.Play();
                powerup.X = x.Next(50, 900);
                powerup.Y = x.Next(50, 500);
            }
            Refresh();
        }
    }
}
