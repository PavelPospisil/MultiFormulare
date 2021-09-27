/*
 * Created by SharpDevelop.
 * User: pospi
 * Date: 11.01.2021
 * Time: 23:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shooter_Game_semestralka_pospisil
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label Ammo;
		private System.Windows.Forms.Label Kills;
		private System.Windows.Forms.Label Health;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox picturebox3;
		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button playButton;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonSettings;
		private System.Windows.Forms.Button button52;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Ammo = new System.Windows.Forms.Label();
			this.Kills = new System.Windows.Forms.Label();
			this.Health = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.picturebox3 = new System.Windows.Forms.PictureBox();
			this.player = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.playButton = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button52 = new System.Windows.Forms.Button();
			this.buttonSettings = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturebox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Ammo
			// 
			this.Ammo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Ammo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Ammo.Location = new System.Drawing.Point(45, 19);
			this.Ammo.Name = "Ammo";
			this.Ammo.Size = new System.Drawing.Size(137, 24);
			this.Ammo.TabIndex = 0;
			this.Ammo.Text = "Náboje:";
			// 
			// Kills
			// 
			this.Kills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Kills.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Kills.Location = new System.Drawing.Point(351, 19);
			this.Kills.Name = "Kills";
			this.Kills.Size = new System.Drawing.Size(115, 24);
			this.Kills.TabIndex = 1;
			this.Kills.Text = "Zabití: 0";
			// 
			// Health
			// 
			this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Health.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Health.Location = new System.Drawing.Point(621, 19);
			this.Health.Name = "Health";
			this.Health.Size = new System.Drawing.Size(71, 24);
			this.Health.TabIndex = 2;
			this.Health.Text = "Život:";
			// 
			// progressBar1
			// 
			this.progressBar1.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.progressBar1.Location = new System.Drawing.Point(698, 20);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(213, 23);
			this.progressBar1.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Shooter_Game_semestralka_pospisil.Properties.Resources.zdown;
			this.pictureBox1.Location = new System.Drawing.Point(45, 142);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(71, 71);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "zombie";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::Shooter_Game_semestralka_pospisil.Properties.Resources.zup;
			this.pictureBox2.Location = new System.Drawing.Point(383, 517);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(71, 71);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "zombie";
			// 
			// picturebox3
			// 
			this.picturebox3.BackColor = System.Drawing.Color.Transparent;
			this.picturebox3.Image = global::Shooter_Game_semestralka_pospisil.Properties.Resources.zdown;
			this.picturebox3.Location = new System.Drawing.Point(789, 113);
			this.picturebox3.Name = "picturebox3";
			this.picturebox3.Size = new System.Drawing.Size(71, 71);
			this.picturebox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picturebox3.TabIndex = 6;
			this.picturebox3.TabStop = false;
			this.picturebox3.Tag = "zombie";
			// 
			// player
			// 
			this.player.BackColor = System.Drawing.Color.Transparent;
			this.player.Image = global::Shooter_Game_semestralka_pospisil.Properties.Resources.up;
			this.player.Location = new System.Drawing.Point(436, 287);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(71, 71);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.player.TabIndex = 7;
			this.player.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10000000;
			this.timer1.Tick += new System.EventHandler(this.gameEngine);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.groupBox2.Controls.Add(this.playButton);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 49);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(899, 557);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Alfa v.12.4.08";
			// 
			// playButton
			// 
			this.playButton.AutoSize = true;
			this.playButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.playButton.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.playButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.playButton.Location = new System.Drawing.Point(3, 484);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(893, 70);
			this.playButton.TabIndex = 9;
			this.playButton.Text = "PLAY";
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.PlayButtonClick);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label10.Location = new System.Drawing.Point(33, 46);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(374, 132);
			this.label10.TabIndex = 8;
			this.label10.Text = "Před vstupem do hry:\r\n- Nábojů je pro začátek deset\r\n- Box padne, až když je poče" +
	"t nábojů = 0\r\n- Zabití = Score\r\n- Počet nepřátel =< 3\r\n- Příjemnou zábavu\r\n";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label9.Location = new System.Drawing.Point(516, 298);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 42);
			this.label9.TabIndex = 7;
			this.label9.Text = "+";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label8.Location = new System.Drawing.Point(183, 370);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(143, 42);
			this.label8.TabIndex = 6;
			this.label8.Text = "Střelba";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(666, 370);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 42);
			this.label7.TabIndex = 5;
			this.label7.Text = "Pohyb";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(41, 281);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(427, 71);
			this.label6.TabIndex = 4;
			this.label6.Text = "Space";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(694, 281);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 71);
			this.label5.TabIndex = 3;
			this.label5.Text = "↓";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(777, 281);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 71);
			this.label4.TabIndex = 2;
			this.label4.Text = "→";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(609, 281);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 71);
			this.label3.TabIndex = 1;
			this.label3.Text = "←";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(694, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 71);
			this.label2.TabIndex = 0;
			this.label2.Text = "↑";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImage = global::Shooter_Game_semestralka_pospisil.Properties.Resources.SpeedrunShooterV;
			this.groupBox1.Controls.Add(this.button52);
			this.groupBox1.Controls.Add(this.buttonSettings);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(899, 642);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Alfa v.5.06";
			// 
			// button52
			// 
			this.button52.Location = new System.Drawing.Point(817, 425);
			this.button52.Name = "button52";
			this.button52.Size = new System.Drawing.Size(75, 23);
			this.button52.TabIndex = 7;
			this.button52.Text = "button3";
			this.button52.UseVisualStyleBackColor = true;
			this.button52.Click += new System.EventHandler(this.Button52Click);
			// 
			// buttonSettings
			// 
			this.buttonSettings.AutoSize = true;
			this.buttonSettings.BackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSettings.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonSettings.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.buttonSettings.Location = new System.Drawing.Point(704, 506);
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Size = new System.Drawing.Size(189, 46);
			this.buttonSettings.TabIndex = 3;
			this.buttonSettings.Text = "Settings";
			this.buttonSettings.UseVisualStyleBackColor = false;
			this.buttonSettings.Click += new System.EventHandler(this.ButtonSettingsClick);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.button2.Location = new System.Drawing.Point(775, 454);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 46);
			this.button2.TabIndex = 2;
			this.button2.Text = "Credits";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.button1.Location = new System.Drawing.Point(704, 558);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(192, 80);
			this.button1.TabIndex = 1;
			this.button1.Text = "PLAY";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.label1.Location = new System.Drawing.Point(3, 559);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(564, 80);
			this.label1.TabIndex = 0;
			this.label1.Text = "Speed run Shooter V";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(923, 666);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.player);
			this.Controls.Add(this.picturebox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.Health);
			this.Controls.Add(this.Kills);
			this.Controls.Add(this.Ammo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Speed_run_Shooter_V_alfa";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturebox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
