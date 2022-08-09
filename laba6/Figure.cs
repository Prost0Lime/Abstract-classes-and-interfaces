using System;

namespace laba6
{
	/// Базовый класс
	
	public abstract class Figure
	{
		private int X,Y;
		
		public int x {
			get{return X;}
			set{X=value;}
		}
		public int y {
			get{return Y;}
			set{Y=value;}
		}
		
		public abstract void DrawIt(int x, int y);
	}
}
