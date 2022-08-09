using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;   
namespace laba6{
public class Rectangle : Figure
{
		PictureBox picture; 
	    public Rectangle (int x, int y, PictureBox p)
	    {
	        this.x = x;
	        this.y = y;
	        picture = p;        
	    }
	    public override void DrawIt(int x1, int y1)
	    {
	        Bitmap bmp = new Bitmap(picture.Width, picture.Height); 
	        Graphics graph = Graphics.FromImage(bmp);
	        Pen pn = new Pen(Color.Goldenrod, 2);
	        graph.DrawRectangle(pn, x, y, x1, y1);
	        picture.Image = bmp; 
	    }
	}
}

