/*
 * Created by SharpDevelop.
 * User: pospi
 * Date: 26.09.2021
 * Time: 23:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shooter_Game_semestralka_pospisil
{
	partial class Settings
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonSet;
		
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
		private void InitializeComponent()
		{
			
			this.button5 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonSet = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button5.ForeColor = System.Drawing.Color.Red;
			this.button5.Location = new System.Drawing.Point(424, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(28, 23);
			this.button5.TabIndex = 21;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"5",
			"10",
			"15",
			"20"});
			this.comboBox1.Location = new System.Drawing.Point(213, 245);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(140, 21);
			this.comboBox1.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(68, 243);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 23;
			this.label1.Text = "Ammo:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(68, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 24;
			this.label2.Text = "Zombie speed:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(68, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 23);
			this.label3.TabIndex = 26;
			this.label3.Text = "Player Health:";
			// 
			// trackBar2
			// 
			this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.trackBar2.Location = new System.Drawing.Point(213, 115);
			this.trackBar2.Maximum = 200;
			this.trackBar2.Minimum = 25;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(140, 45);
			this.trackBar2.TabIndex = 27;
			this.trackBar2.Value = 25;
			this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2Scroll);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.numericUpDown1.Location = new System.Drawing.Point(213, 179);
			this.numericUpDown1.Maximum = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(140, 22);
			this.numericUpDown1.TabIndex = 28;
			this.numericUpDown1.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(360, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 23);
			this.label4.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.label5.Location = new System.Drawing.Point(146, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 43);
			this.label5.TabIndex = 30;
			this.label5.Text = "Settings";
			// 
			// buttonSet
			// 
			this.buttonSet.AutoSize = true;
			this.buttonSet.BackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSet.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonSet.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.buttonSet.Location = new System.Drawing.Point(334, 322);
			this.buttonSet.Name = "buttonSet";
			this.buttonSet.Size = new System.Drawing.Size(118, 46);
			this.buttonSet.TabIndex = 31;
			this.buttonSet.Text = "Set";
			this.buttonSet.UseVisualStyleBackColor = false;
			this.buttonSet.Click += new System.EventHandler(this.ButtonSetClick);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(464, 380);
			this.Controls.Add(this.buttonSet);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			//
			// ButtonSet
			//
		    this.buttonSet.Size = new System.Drawing.Size(118, 46);
			this.buttonSet.TabIndex = 31;
			this.buttonSet.Text = "Set";
			this.buttonSet.UseVisualStyleBackColor = false;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(464, 380);
			this.Controls.Add(this.buttonSet);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
