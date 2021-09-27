/*
 * Created by SharpDevelop.
 * User: pospi
 * Date: 26.09.2021
 * Time: 23:48
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
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public partial class Settings : Form
	{
		public MainForm frm = new MainForm();
		public int Hp
		{
			get{return trackBar2.Value;}
		}
		public int Spd
		{
			get{return decimal.ToInt32(numericUpDown1.Value);}
		}
		public int Am
		{
			get{return int.Parse(comboBox1.Text);}
		}
		
		public Settings(MainForm stg)
		{
			InitializeComponent();
			label4.Text = "25";
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void TrackBar2Scroll(object sender, EventArgs e)
		{
			label4.Text = trackBar2.Value.ToString();
		}
		
		public void ButtonSetClick(object sender, EventArgs e)
		{	
			frm.Hp1 = Hp;
			frm.Spd1 = Spd;
			frm.Am1 = Am;
			frm.Update();
			
//			form.SetH = trackBar2.Value;
//			form.SetS = decimal.ToInt32(numericUpDown1.Value);
//			form.SetA = int.Parse(comboBox1.Text);
			this.Close();
//			MessageBox.Show(form.SetH.ToString());
//			MessageBox.Show(form.SetA.ToString());
		}
	}
}
