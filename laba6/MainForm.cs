/*
 * Created by SharpDevelop.
 * User: adfgh
 * Date: 26-04-2019
 * Time: 14:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
/*	Первый вариант иерархии классов,  2, 3  варианты фигур.
 
			Иерархия включает абстрактный базовый класс под названием 
			«Фигура», и два его подкласса. Абстрактный класс содержит
 			абстрактный метод рисования фигуры и два поля или два 
			свойства, определяющие размер фигуры. В подклассах
 			переопределяется абстрактный метод.
		 
		 2. Прямоугольник, совпадающий с базовым прямоугольником.
		 3. Шестиугольник (не обязательно правильный), 
			расположение шестиугольника в базовом прямоугольнике
 			студент определяет самостоятельно.
	 */
namespace laba6
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();	
		}
		
		Figure gif;
		Dialog showIt = new Dialog();
		void Button1Click(object sender, EventArgs e)
		{
	showIt.ShowDialog();
			
			textBox1.Text = showIt.X.ToString();
			textBox2.Text = showIt.Y.ToString();
			
			gif = new Rectangle(showIt.X, showIt.Y, pictureBox1);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
	try{
				int x = Convert.ToInt32(textBox1.Text);
				int y = Convert.ToInt32(textBox2.Text);
				
				gif = new Hexagon(x, y, pictureBox1);
				
			}catch(FormatException){
				MessageBox.Show("Не заданы координаты");
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
	pictureBox1.Image = null;
			pictureBox1.BackColor = Color.White;
			
			try{
				gif.DrawIt(75,75);
			}catch(NullReferenceException){
				MessageBox.Show("Вы не выбрали объект");
			}
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		
	}
}
