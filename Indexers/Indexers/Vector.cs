using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexers
{
    class Vector
    {
        // from here...
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator +(Vector v, double scalar)
        {
            return new Vector(v.X + scalar, v.Y + scalar);
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return ((v1.X == v2.X) && (v1.Y == v2.Y));
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }
        // ...to here is code reused from the Operator Overloading project 

        // new code

        // indexing is basically overloading the "[" and "]" operators

        // the "this[...]" indicates indexing
        public double this[int index]
        {
            get
            {
                if      (index == 0) { return this.X; }
                else if (index == 1) { return this.Y; }
                else { throw new IndexOutOfRangeException(); }
            }
            set
            {
                if (index == 0) { this.X = value; }
                else if (index == 1) { this.Y = value; }
                else { throw new IndexOutOfRangeException(); }
            }
        }

        // any data type can be used with indexing
        public double this[string component]
        {
            get
            {
                if (component == "x" || component == "X") { return this.X; }
                else if (component == "y" || component == "Y") { return this.Y; }
                else { throw new IndexOutOfRangeException(); }
            }
            set
            {
                if (component == "x" || component == "X") { this.X = value; }
                else if (component == "y" || component == "Y") { this.Y = value; }
                else { throw new IndexOutOfRangeException(); }
            }
        }

        // multiple indices can be indexed at the same time
        public double this[string component, int index]
        {
            get
            {
                // throws an exception as there is no realistic way to implement this
                throw new Exception();
            }
            set
            {
                // throws an exception as there is no realistic way to implement this
                throw new Exception();
            }
        }
    }
}
