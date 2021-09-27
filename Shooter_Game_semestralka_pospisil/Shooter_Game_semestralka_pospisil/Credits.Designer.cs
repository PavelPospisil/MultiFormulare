/*
 * Created by SharpDevelop.
 * User: pospi
 * Date: 26.09.2021
 * Time: 21:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shooter_Game_semestralka_pospisil
{
	partial class Credits
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(576, 375);
			this.textBox1.TabIndex = 19;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button3.ForeColor = System.Drawing.Color.Red;
			this.button3.Location = new System.Drawing.Point(549, 18);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(28, 23);
			this.button3.TabIndex = 20;
			this.button3.Text = "X";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// Credits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 400);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Credits";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Credits";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
