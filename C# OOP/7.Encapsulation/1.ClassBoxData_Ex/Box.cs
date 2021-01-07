
using System;

namespace _1.ClassBoxData_Ex
{
    public class Box
    {
		private double length;
		private double width;
		private double height;

		public Box(double length, double width, double height)
		{
			this.Length = length;
			this.Width = width;
			this.Height = height;
		}

		public double Length
		{
			get { return this.length; }
			private set { 
				if(value <= 0)
				{
					throw new ArgumentException("Length cannot by negative!");
				}
				this.length = value; 
			}
		}

		

		public double Width
		{
			get { return this.width; }
			private set {
				if (value <= 0)
				{
					throw new ArgumentException("Width cannot by negative!");
				}
				this.width = value; }
		}

		

		public double Height
		{
			get { return this.height; }
			private set {
				if (value <= 0)
				{
					throw new ArgumentException("Height cannot by negative!");
				}
				this.height = value; }
		}

		public double LateralSurfaceArea()
		{
			return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
		}

		public double Volume()
		{
			return this.Length * this.Width * this.Height;
		}

		public double Area()
		{
			return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.width * this.Height;
		}
	}
}
