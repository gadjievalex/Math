/*
 * Сделано в SharpDevelop.
 * Пользователь: GadjievAlex
 * Дата: 26.11.2014
 */
using System;

namespace DefaultNamespace
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Vector
	{
		private double fx;
        private double fy;
 
        public Vector(double ax, double ay)
        {
            fx = ax;
            fy = ay;
        }
 
        public double x
        {
            get
            {
                return fx;
            }
            set
            {
                fx = value;
            }
        }
 
        public double y
        {
            get
            {
                return fy;
            }
            set
            {
                fy = value;
            }
 
        }
 
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }
 
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y);
        }
	}
}