using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace laba6
{
	/// <summary>
	/// Description of Hexagon.
	/// </summary>
	public class Hexagon : Figure{
	
		PictureBox picture;
			
		public Hexagon(int x, int y, PictureBox p)
		{
			this.x = x;
			this.y = y;
			picture = p;
		}
		
		
		public override void DrawIt(int x1, int y1){
			
			
			Bitmap bmp = new Bitmap(picture.Width, picture.Height);
			Graphics graph = Graphics.FromImage(bmp);
			Pen MagicPen = new Pen(Color.LightPink, 2);
			
			int N = 6;
			Point[] ManyManyPoints = new Point[N];
			int r = 50;
			double angle = Math.PI/3;
			
			
				for (int i = 0; i < N; i++)
				{
					angle = 2 * Math.PI * i / N - r;
					ManyManyPoints[i].X = Convert.ToInt16(r * Math.Cos(angle)) + x1;
					ManyManyPoints[i].Y = Convert.ToInt16(r * Math.Sin(angle)) + y1;
				
				}
				graph.DrawPolygon(MagicPen, ManyManyPoints);
			
			
			picture.Image = bmp;
		}
	}
}
