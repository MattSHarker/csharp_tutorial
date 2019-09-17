using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class Point
    {
        private double x;
        private double y;

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                OnPointChanged();   // If the event handler is attached, this will raise it
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                OnPointChanged();   // ditto
            }
        }

        public event EventHandler PointChanged;

        public void OnPointChanged()
        {
            if(PointChanged != null)
            {
                PointChanged(this, EventArgs.Empty);
            }
        }
    }
}
