using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EllipseFactory : Object2DFactory
    {
        public override AObject2D GetObject2D()
        {
            return new MyEllipse();
        }
    }
}
