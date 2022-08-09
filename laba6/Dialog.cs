/*
 * Created by SharpDevelop.
 * User: adfgh
 * Date: 26-04-2019
 * Time: 23:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba6
{
	/// <summary>
	/// Description of Dialog.
	/// </summary>
	public partial class Dialog : Form
	{
		public Dialog()
		{
			
			InitializeComponent();	
		}
		
		public int X = 75, Y= 80;
		
		void Button1Click(object sender, EventArgs e)
		{
		try{
				X = Convert.ToInt32(textBox1.Text);
				Y = Convert.ToInt32(textBox2.Text);
				Close();
			}catch(FormatException){
				MessageBox.Show("Задайте координаты!");
		}
	}
	}}
