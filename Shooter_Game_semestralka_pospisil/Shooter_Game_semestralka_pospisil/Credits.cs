/*
 * Created by SharpDevelop.
 * User: pospi
 * Date: 26.09.2021
 * Time: 21:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shooter_Game_semestralka_pospisil
{
	/// <summary>
	/// Description of Credits.
	/// </summary>
	public partial class Credits : Form
	{
		public Credits(MainForm cr)
		{
			InitializeComponent();
		}
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
