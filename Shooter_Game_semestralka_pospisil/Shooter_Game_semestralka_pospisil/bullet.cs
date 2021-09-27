/*
 * Created by SharpDevelop.
 * User: pospi
 * Date: 28.12.2020
 * Time: 0:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Shooter_Game_semestralka_pospisil
{
	public class bullet
	{
		public string direction;
        public int speed = 20; 
        PictureBox Bullet = new PictureBox(); 
        Timer tm = new Timer(); 
 
        public int bulletLeft;
        public int bulletTop;
        
		
		public void mkBullet(Form form)
        {
            Bullet.BackColor = Color.Yellow;
            Bullet.Size = new Size(6, 6);
            Bullet.Tag = "bullet"; 
            Bullet.Left = bulletLeft; 
            Bullet.Top = bulletTop; 
            Bullet.BringToFront();
            form.Controls.Add(Bullet);
 
            tm.Interval = speed;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start(); // start timeru
        }
        
        public void tm_Tick(object sender, EventArgs e)
        {
            switch (direction) {
            	case "left":
            	Bullet.Left -= speed;	
            	break;
            	
            	case "right":
            	Bullet.Left += speed;
            	break;
            	
           	 	case "up":
            	Bullet.Top -= speed;
            	break;
            	
            	case "down":
            	Bullet.Top += speed;
            	break;
            }
        
            if (Bullet.Left < 16 || Bullet.Left > 860 || Bullet.Top < 10 || Bullet.Top > 616)
            {
                tm.Stop(); 
                tm.Dispose(); 
                Bullet.Dispose();
                tm = null; 
                Bullet = null; 
            }
        }
		
	}
}
