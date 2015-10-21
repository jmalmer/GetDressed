using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDressed
{
    partial class Model
    {
    }

    partial class Person
    {
        Garment TorsoGarment { get; set; }
        Garment LegGarment { get; set; }
    }

    partial class Garment
    {

    }

}
