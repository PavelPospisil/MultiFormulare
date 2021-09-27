/*
 * Created by SharpDevelop.
 * User: pospi
 * Date: 27.12.2020
 * Time: 23:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;
using System.Data;

namespace Shooter_Game_semestralka_pospisil
{
	// snaha o změnu barvy ProgressBaru, nicméně to hází chybu, takže to bude bez toho
//	public static class ModifyProgressBarColor //1 = normal (zelená); 2 = error (červená); 3 = warning (žlutá) 
//		{
//			[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
//		    static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
//		    public static void SetState(this ProgressBar pBar, int state)
//		    {
//		        SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
//		    }
//		}
	
	public partial class MainForm : Form
	{
		//pohyb hráče po obrazovce
		bool goup;
		bool godown;
		bool goleft; 
		bool goright;
		
//		public int SetH { get; set; }
//		public int SetS { get; set; }
//		public int SetA { get; set; }
		public static int prom1;
		public static int prom2;
		public static int prom3;
		
		public int Hp1
		{
			set{prom1=value;}
		}
		public int Spd1
		{
			set{prom2=value;}
		}
		public int Am1
		{
			set{prom3=value;}
		}
		
		string facing = "up"; //pohled pro pohyb kulek
		
		double playerHealth = prom1; //začáteční vybavení hráče
		int speed = 10; 
		int ammo = prom3; 
		
		int zombieSpeed = prom2; // this integer will hold the speed which the zombies move in the game
		int score = 0; //...
		bool gameOver = false; //bolean pro konec hry
		Random rnd = new Random(); //random pro např. spawn zombies
		
		public MainForm()
		{	
			InitializeComponent();
		}
		
		void PlayButtonClick(object sender, EventArgs e)
		{
			groupBox2.Hide();
			playButton.Enabled = false;
			timer1.Interval = 20;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
//			MessageBox.Show(prom1.ToString());
//			MessageBox.Show(prom2.ToString());
//			MessageBox.Show(prom3.ToString());

			groupBox1.Hide();
			button1.Enabled = false;
			//groupBox3.Visible = false;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//groupBox3.Visible = true;
			Credits crdS = new Credits(this);
			crdS.Show();
		}
		
		void ButtonSettingsClick(object sender, EventArgs e)
		{
			Settings stg = new Settings(this);
			stg.Show();
		}
		
//		void Button3Click(object sender, EventArgs e)
//		{
//			groupBox3.Visible = false;
//		}
		
		void keyisdown(object sender, KeyEventArgs e) //změna směru pohledu + pohyb
		{
			if (gameOver) return;
 			
			switch (e.KeyCode) {
				
				case Keys.Left:
					goleft = true;
                	facing = "left";
                	player.Image = Properties.Resources.left;
					break;
					
				case Keys.Right:
					goright = true; 
                	facing = "right"; 
                	player.Image = Properties.Resources.right; 
					break;
					
				case Keys.Up:
					facing = "up"; 
                	goup = true; 
                	player.Image = Properties.Resources.up; 
					break;
					
				case Keys.Down:
					facing = "down"; 
                	godown = true; 
                	player.Image = Properties.Resources.down;
					break;
			}
            
		}
		
		void keyisup(object sender, KeyEventArgs e)
		{
			if (gameOver) return;
			
			switch (e.KeyCode) 
			{	
				case Keys.Left:
				goleft = false;
				break;
				
				case Keys.Right:
				goright = false;
				break;
				
				case Keys.Up:
				goup = false;
				break;
				
				case Keys.Down:
				godown = false;
				break;
			}
			
				if(e.KeyCode == Keys.Space && ammo > 0)
				{
					ammo--;
					shoot(facing);
					if (ammo < 1)
					{
						DropAmmo();
					}
				}
		}
		
		void gameEngine(object sender, EventArgs e)
		{
			
			if (playerHealth > 1) //naživu
            {
                progressBar1.Value = Convert.ToInt32(playerHealth);
            }
            else
            {
                // méně než 1hp = smrt
                player.Image = Properties.Resources.dead;
                timer1.Stop(); // stop timeru
                gameOver = true;
                
                int scoreOver = score;
                string message = " ? ? Chceš to zkusit znovu ? ? \r\n" + "Tvé score bylo " + score;
                string caption = "! ! ! GAME OVER ! ! !";
                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result;
                
                result = MessageBox.Show(message, caption, but);//zpráva o konci
                
                if (result == System.Windows.Forms.DialogResult.Yes) //respawn hráče
                {
                	result = MessageBox.Show("Opravdu?","Opravdu?",but);
                	if (result == System.Windows.Forms.DialogResult.Yes) //respawn hráče
                	{
	                	playerHealth = 100;
	                	player.Image = Properties.Resources.right;
	                	timer1.Start();
	                	gameOver = false;
	                	ammo = 10;
	                	zombieSpeed = 3;
	                	score = score - scoreOver;
	                	player.Left = rnd.Next(20, 700);
	           			player.Top = rnd.Next(20, 600);
                	}
                }
               
                if (result == System.Windows.Forms.DialogResult.No) {
                		this.Close();
                }
                
            }
 
            Ammo.Text = "Náboje: " + ammo; // náboje
            Kills.Text = "Zabití: " + score; // ukazatel zabití
 
//            if (playerHealth < 20)
//            {
//            	progressBar1.SetState(2); //= Color.Red; //nefunguje
//            }
 
            if (goleft && player.Left > 0)
            {
                player.Left -= speed;
            }
            
            if (goright && player.Left + player.Width < 930)
            {
                player.Left += speed;
            }
            
            if (goup && player.Top > 60)
            {
                player.Top -= speed;
            }
 
            if (godown && player.Top + player.Height < 700)
            {
                player.Top += speed;
            }
 
            
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "ammo")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }
 
 
                if (x is PictureBox && x.Tag == "bullet")
                {
        			if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose(); 
                    }
                }
 
                
 
                if (x is PictureBox && x.Tag == "zombie") //pohyb zombies
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        playerHealth -= 1;
                    }
                    
                    if (((PictureBox)x).Left > player.Left)
                    {
                     	((PictureBox)x).Left -= zombieSpeed; 
                     	//((PictureBox)x).Image = Properties.Resources.zleft;
                    }
 
                    if (((PictureBox)x).Top > player.Top)
                    {
                        ((PictureBox)x).Top -= zombieSpeed; 
                        //((PictureBox)x).Image = Properties.Resources.zup; 
                    }
                    if (((PictureBox)x).Left < player.Left)
                    {
                     	((PictureBox)x).Left += zombieSpeed; 
                     	//((PictureBox)x).Image = Properties.Resources.zright; 
                    }
                    if (((PictureBox)x).Top < player.Top)
                    {
                      	((PictureBox)x).Top += zombieSpeed; 
                      	//((PictureBox)x).Image = Properties.Resources.zdown; 
                    }
                }
 
                foreach (Control j in this.Controls)
                {
                	
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "zombie"))
                    {
                        
                        if (x.Bounds.IntersectsWith(j.Bounds))//zabití
                        {
                            score++; 
                            this.Controls.Remove(j); 
                            j.Dispose();
                            this.Controls.Remove(x);
                            x.Dispose();
                            makeZombies();
                        }
                    }
                }
            }
		}
		
		public void DropAmmo() //pád bedny s municí
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammoImage;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(10, 890); 
            ammo.Top = rnd.Next(50, 600);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        }
 
        public void shoot(string direct) //střelba a práce s bullet.cs
        {
            bullet shoot = new bullet(); 
            shoot.direction = direct; 
            shoot.bulletLeft = player.Left + (player.Width / 2); 
            shoot.bulletTop = player.Top + (player.Height / 2); 
            shoot.mkBullet(this); 
        }
 
        public void makeZombies() //generování zombies
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie"; 
            zombie.Image = Properties.Resources.zdown; 
            zombie.Left = rnd.Next(0, 900);
            zombie.Top = rnd.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize; 
            this.Controls.Add(zombie); 
            player.BringToFront(); 
        }
		void Button52Click(object sender, EventArgs e)
		{
			this.Refresh();
		}
	}
}
