using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Furniture
    {
        string material { get; set; }

        string anyFurnitureMethod1();

        string anyFurnitureMethod2();
    }
}
