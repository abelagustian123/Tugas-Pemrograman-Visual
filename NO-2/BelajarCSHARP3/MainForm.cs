/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 28/02/2022
 * Time: 17.17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BelajarCSHARP3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("Senin");
			comboBox1.Items.Add("Selasa");
			comboBox1.Items.Add("Rabu");
			comboBox1.Items.Add("Kamis");
			comboBox1.Items.Add("Jumat");
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			string hari=(string)comboBox1.SelectedItem;
			waktu(hari);
		}
		
		void waktu(string hari)
		{
			listBox1.Items.Clear();
			listBox1.SelectionMode=SelectionMode.MultiSimple;
			if (hari=="Senin")
			{
				listBox1.Items.Add("09.00");
				listBox1.Items.Add("10.00");
				listBox1.Items.Add("13.00");
				listBox1.Items.Add("14.00");
			}
			else if (hari == "Selasa")
			{
				listBox1.Items.Add("09.00");
				listBox1.Items.Add("10.00");
				listBox1.Items.Add("13.00");
				listBox1.Items.Add("14.00");
			}
			else if (hari == "Rabu")
			{
				listBox1.Items.Add("09.00");
				listBox1.Items.Add("10.00");
				listBox1.Items.Add("13.00");
				listBox1.Items.Add("14.00");
			}
			else if (hari == "Kamis")
			{
				listBox1.Items.Add("09.00");
				listBox1.Items.Add("10.00");
				listBox1.Items.Add("13.00");
				listBox1.Items.Add("14.00");
			}
			else if (hari == "Jumat")
			{
				listBox1.Items.Add("09.00");
				listBox1.Items.Add("13.00");
				listBox1.Items.Add("14.00");
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show(" (Pendaftaran Berhasil !)" , "(Terimakasih)", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
