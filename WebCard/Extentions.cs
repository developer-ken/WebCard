using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WebCard
{
    public static class Extentions
    {
        public static Point Minus(this Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static bool CanDisplay(this Screen[] screens, Rectangle rect)
        {
            foreach(Screen screen in screens)
            {
                if (screen.WorkingArea.Contains(rect))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
